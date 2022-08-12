//封装文件上传和聊天。
(function () {
    //生命全局变量
    var webSocketInstance;
    var chatUrl = "ws://localhost:62073/HttpHandlers/WebChatHandler.ashx";
    var isSendFileGroup = false;//是否是群发文件，默认状态不是群发。
    var isOnline = false;
    var mainProcess = {
        //1、初始化基本事件
        init: function () {
            this.initClick();
        },
        //2、建立通讯事件。
        initConnect: function () {
            if (isOnline == false) {
                var newUrl = chatUrl + "?userKey=" + $("#txtUserKey").val();

                webSocketInstance = new WebSocket(newUrl);

                //2.1、建立网络连接的时候触发该事件
                webSocketInstance.onopen = function () {
                    $("#spnNoticeText").html("已经连接！");
                    $("#chatAndFileContainer").attr("style", "display:block");
                }

                //2.2、接受服务器发来的消息触发该事件。
                webSocketInstance.onmessage = function (evt) {
                    $("#messageContent").append(evt.data);
                }

                //2.3、网络错误的时候触发该事件。
                webSocketInstance.onerror = function (evt) {
                    $("#spnNoticeText").html(JSON.stringify(evt));
                }

                //2.4、当连接关闭的时候触发该事件。
                webSocketInstance.onclose = function () {
                    //这里可以根据实际场景编写，比如重连机制。
                    $("#spnNoticeText").html("断开连接！");
                    $("#chatAndFileContainer").attr("style", "display:none");
                }
                isOnline = true;
            }
            else {
                $("#spnNoticeText").html($("#txtUserKey").val() + "用户已经在线了！");
            }
        },
        //3、初始化各种点击事件。
        initClick: function () {
            //3.1、网络连接事件
            $("#btnConnected").on("click", function () {
                if (document.getElementById("txtUserKey") && document.getElementById("txtUserKey").value == "") {
                    $("#spnNoticeText").html("请输入登录用户的标识！");
                    return;
                }
                mainProcess.initConnect();
            });

            //3.2、网络连接事件
            $("#btnClose").on("click", function () {
                if (webSocketInstance && webSocketInstance.readyState == WebSocket.OPEN) {
                    webSocketInstance.close();
                    isOnline = false;
                }
            });

            //3.3、群发消息
            $("#btnSendGroup").on("click", function () {
                if (webSocketInstance) {
                    if (webSocketInstance.readyState == WebSocket.OPEN) {
                        clearUploadProgress();
                        var message = $("#txtContent").val();

                        if (message && message.length > 0) {
                            webSocketInstance.send(message);
                        }

                        if (document.getElementById("file").files.length > 0) {
                            isSendFileGroup = true;
                            uploadFiles();

                            clearFilesUploader();
                        }
                    }
                    else if (webSocketInstance.readyState == WebSocket.CLOSED) {
                        $("#spnNoticeText").html("已经与服务器断开连接！");
                    }
                    else if (webSocketInstance.readyState == WebSocket.CONNECTING) {
                        $("#spnNoticeText").html("正在尝试与服务器建立连接！");
                    }
                    else if (webSocketInstance.readyState == WebSocket.CLOSING) {
                        $("#spnNoticeText").html("正在关闭与服务器的连接！");
                    }
                }
            });

            //3.4、私聊发消息
            $("#btnSendPrivate").on("click", function () {
                var userKey = $("#txtPrivateUserKey").val();
                if (userKey == null || userKey == "" || userKey.length <= 0) {
                    $("#spnNoticeText").html("请输入接收用户的标识！");
                    return;
                }

                if (webSocketInstance) {
                    if (webSocketInstance.readyState == WebSocket.OPEN) {
                        clearUploadProgress();
                        var message = $("#txtContent").val();

                        //对消息进行拼接 "$--$--**"+ userKey +"$--$--**"+"要发送消息的内容";
                        if (message && message.length > 0) {
                            var finalMessage = "$--$--**" + userKey + "$--$--**" + message;
                            webSocketInstance.send(finalMessage);
                        }

                        if (document.getElementById("file").files.length > 0) {
                            isSendFileGroup = false;
                            uploadFiles();

                            clearFilesUploader();
                        }
                    }
                    else if (webSocketInstance.readyState == WebSocket.CLOSED) {
                        $("#spnNoticeText").html("已经与服务器断开连接！");
                    }
                    else if (webSocketInstance.readyState == WebSocket.CONNECTING) {
                        $("#spnNoticeText").html("正在尝试与服务器建立连接！");
                    }
                    else if (webSocketInstance.readyState == WebSocket.CLOSING) {
                        $("#spnNoticeText").html("正在关闭与服务器的连接！");
                    }
                }
            });
        }
    };

    //开始上传文件部分集成。
    var filesUrl = "ws://localhost:62073/HttpHandlers/UploadFilesHandler.ashx";
    function uploadOperate(file) {
        if (file) {
            var _this = this;
            this.reader = new FileReader();//读取文件对象。
            this.step = 1024 * 256; //每次读取文件的大小
            this.curLoaded = 0; //当前读取位置
            this.file = file; //当前文件对象。
            this.enableRead = true;//指示是否可以继续读取。
            this.total = file.size;//文件的总大小。
            this.startTime = new Date();//开始读取时间。
            this.createItem();
            this.initWebSocket(function () {
                _this.bindReader();
            });
        }
        else {
            var _this = this;
            this.step = 1024 * 256;
            this.curLoaded = 0;
            this.enableRead = true;
            this.total = 0;
        }
    }
    uploadOperate.prototype = {
        //绑定读取事件
        bindReader: function () {
            var _this = this;
            var reader = this.reader;
            var webSocketFileInstance = this.webSocketFileInstance;
            reader.onload = function (e) {
                //判断是否能再次读取
                if (_this.enableRead == false) {
                    return;
                }
                //根据当前缓冲区控制读取速度
                if (webSocketFileInstance.bufferedAmount >= _this.step * 20) {
                    setTimeout(function () {
                        _this.loadSuccess(e.loaded);
                    }, 5);
                } else {
                    _this.loadSuccess(e.loaded);
                }
            }
            //开始读取
            _this.readBlob();
        },
        //成功读取，继续处理
        loadSuccess: function (loaded) {
            var _this = this;
            var webSocketFileInstance = _this.webSocketFileInstance;
            //使用 WebSocket 将二进制输出上传到服务器。
            var blob = _this.reader.result;
            if (_this.curLoaded <= 0) {
                webSocketFileInstance.send(_this.file.name);
            }
            webSocketFileInstance.send(blob);
            //当前发送完成，继续读取。
            _this.curLoaded += loaded;
            if (_this.curLoaded < _this.total) {
                _this.readBlob();
            }
            else {
                //发送读取完成
                webSocketFileInstance.send("[file:{(:finished:)}200]");
                this.showInfo('<div class=\"fileUploadedFinished\">文件名：' + fileNameTrim(_this.file.name, 6) + '，文件大小：【' + (_this.curLoaded / (1024 * 1024)).toFixed(3) + '】M，上传时间：【' + ((new Date().getTime() - _this.startTime.getTime()) / 1000) + '】秒！</div>');
            }
            //显示进度
            _this.showProgress();
        },
        //创建显示项
        createItem: function () {
            var _this = this;
            var blockquote = document.createElement("blockquote");
            var abort = document.createElement("input");
            abort.type = 'button';
            abort.value = '暂停';
            abort.onclick = function () {
                _this.stop();
            };
            blockquote.appendChild(abort);

            var containue = document.createElement("input");
            containue.type = 'button';
            containue.value = '继续';
            containue.onclick = function () {
                _this.containue();
            };
            blockquote.appendChild(containue);

            var progress = document.createElement('progress');
            progress.style.width = '300px';
            progress.max = 100;
            progress.value = 0;
            blockquote.appendChild(progress);
            _this.progressBox = progress;

            var status = document.createElement('span');
            status.id = 'Status';
            blockquote.appendChild(status);
            _this.statusBox = status;

            document.getElementById('uploadProgress').appendChild(blockquote);
        },
        //显示进度
        showProgress: function () {
            var _this = this;
            var percent = ((_this.curLoaded / _this.total) * 100).toFixed();
            _this.progressBox.value = percent;
            _this.statusBox.innerHTML = percent;
        },
        //读取文件
        readBlob: function () {
            var blob = this.file.slice(this.curLoaded, this.curLoaded + this.step);
            this.reader.readAsArrayBuffer(blob);
        },
        //暂停读取
        stop: function () {
            this.enableRead = false;
            var percentValue = this.percent(this.curLoaded / this.total);
            if (percentValue != '100%') {
                this.showInfo("<div class=\"noticeMessageInContainer\">读取终止，已读取：" + percentValue + "</div>");
            }
            this.reader.abort();
        },
        //继续读取
        containue: function () {
            var percentValue = this.percent(this.curLoaded / this.total);
            if (percentValue != '100%') {
                this.enableRead = true;
                this.readBlob();
                this.showInfo("<div class=\"noticeMessageInContainer\">读取继续，已读取：" + percentValue + "</div>");
            }
            else {
                this.enableRead = false;
            }
        },
        //计算百分比
        percent: function (data) {
            if (data == 0) { return 0; }
            var valuePercent = Number(data * 100).toFixed();
            valuePercent += "%";
            return valuePercent;
        },
        //显示日志
        showInfo: function (data) {
            var html = "";
            html += data;
            document.getElementById("messageContent").innerHTML = document.getElementById("messageContent").innerHTML + html;
            var divLogContainer = document.getElementById("messageContent");
            divLogContainer.scrollTop = divLogContainer.scrollHeight;
        },
        //初始化 WebSocket
        initWebSocket: function (onSuccess) {
            var _this = this;
            var webSocketFileInstance = this.webSocketFileInstance = new WebSocket(filesUrl);

            webSocketFileInstance.onopen = function () {
                console.log("connect 链接创建成功");
                if (onSuccess) {
                    onSuccess();
                }
            }
            webSocketFileInstance.onmessage = function (e) {
                var data = e.data;
                if (isNaN(data) == false) {
                    showInfo('后台接受成功：' + data);
                }
                else {
                    console.info(data);
                }
            }
            webSocketFileInstance.onclose = function (e) {
                //终止读取
                _this.stop();
                showInfo("WebSocket 连接已经断开！");
                console.log("WebSocket 连接已断开。");
            }
            webSocketFileInstance.onerror = function (e) {
                _this.stop();
                showInfo("发生异常：" + e.message);
                console.log("发生异常：" + e.message);
            }
        }
    };
    window.uploadOperate = uploadOperate;
    window.mainProcess = mainProcess;
})();

$(function () {
    mainProcess.init();
});

//上传文件的速度取决于每次 send() 的数据的大小。Google 之所以会慢，是因为他每次 send 的数据很小。
function uploadFiles() {
    var fileController = document.getElementById("file");
    checkAndUploadCore(fileController, true);
}

//检查文件
var fileController2 = document.getElementById("file");
fileController2.onchange = function () {
    clearUploadProgress();
    document.getElementById("txtContent").value = "";
    checkAndUploadCore(fileController2, false);
}

//如果文件名太长，就会修剪。
//fileName:文件名
//length:要截取文件名的长度。
function fileNameTrim(fileName, length) {
    if (fileName && fileName.length > 0 && fileName != "") {
        if (length > 0 && length >= fileName.length) {
            return fileName;
        }
        else {
            return fileName.substring(0, length) + "...";
        }
    }
}

//清除文件上传的进度条显示。为下一次做准备。
function clearUploadProgress() {
    uploadOperate();
    document.getElementById("uploadProgress").innerHTML = "";
}

//文件上传后将控件置为初始状态。
function clearFilesUploader() {
    document.getElementById("file").value = "";
}

//核心的上传文件的方法。
//uploader:上传文件的控件。
//isUpload:是否开始上传文件。
function checkAndUploadCore(uploader, isUpload) {
    if (uploader && uploader.files.length > 0) {
        var maxTotalSize = 5000;//单位：M
        var files = uploader.files;
        var fileTotalSize = 0;
        var fileCount = 5;
        var fileTypes = [".jpg", ".gif", ".bmp", ".png", "jpeg", ".rar", ".zip", ".txt", ".doc", ".ppt", ".xls", ".pdf", ".csv", ".docx", ".xlsx"];

        //1、验证上传文件的格式。
        var isValid = false;
        var fileEnd = '';
        if (fileTypes && fileTypes.length > 0) {
            for (var m = 0; m < files.length; m++) {
                fileEnd = files[m].name.substring(files[m].name.lastIndexOf("."));
                isValid = false;
                for (var i = 0; i < fileTypes.length; i++) {
                    if (fileEnd.toLowerCase() == fileTypes[i].toLowerCase()) {
                        isValid = true;
                        continue;
                    }
                }
                if (!isValid) {
                    break;
                }
            }
            if (!isValid) {
                alert("不支持此文件类型");
                uploader.value = '';
                return false;
            }
        }

        //2、检查文件上传的个数。
        if (files.length > 0 && files.length > fileCount) {
            alert("最多只能上传【" + fileCount + "】个文件！");
            uploader.value = '';
            return;
        }

        //3、检查文件的总大小。
        for (var i = 0; i < files.length; i++) {
            fileTotalSize += files[i].size;
        }
        fileTotalSize = fileTotalSize / (1024 * 1024);
        fileTotalSize = fileTotalSize.toFixed(3);
        if (fileTotalSize > maxTotalSize) {
            alert("上传文件总自己额大小不能大于【" + (maxTotalSize / 1024).toFixed() + "】G!");
            uploader.value = '';
            return;
        }

        //4、检查文件名是否有效。
        var isFileNameValid = true;
        var fileName = '';
        var containSpecial = RegExp(/[(\ )(\~)(\!)(\@)(\#)(\$)(\%)(\^)(\&)(\*)(\()(\))(\+)(\=)(\[)(\])(\{)(\})(\|)(\:)(\;)(\')(\")(\,)(\<)(\.)(\>)(\/)(\?)]+/);
        for (var m = 0; m < files.length; m++) {
            fileName = files[m].name.substring(0, files[m].name.lastIndexOf("."));
            if (containSpecial.test(fileName)) {
                isFileNameValid = false;
                break;
            }
        }
        if (!isFileNameValid) {
            alert("文件名包含特殊字符，不可以上传！");
            uploader.value = '';
            return;
        }
    }
    else {
        return;
    }

    if (isUpload) {
        for (var i = 0; i < files.length; i++) {
            var file = files[i];
            var operate = new uploadOperate(file);
        }
    }
    else {
        var fileNameList = "";
        for (var i = 0; i < files.length; i++) {
            var file = files[i];
            if (i == files.length - 1) {
                fileNameList += file.name;
            } else {
                fileNameList += file.name + "\n";
            }
        }
        document.getElementById("txtContent").value = fileNameList;
    }
}
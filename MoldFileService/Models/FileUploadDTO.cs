namespace WebSocketDemo.Core.Models
{
    public class FileUploadDTO
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public long LastModified { get; set; }
        public string FileType { get; set; }
        public string UserName { get; set; }
        public int DownLoadCount { get; set; }
        public string FileSavePath { get; set; }
    }


    public class MoldFileInfo
    {
        public int Vpid  { get; set; }
        public int ModID { get; set; }
        
        public string hash { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int chunks { get; set; }

        public string username { get; set; }

    }

    /// <summary>
    /// 校验 hash 头
    /// </summary>
    public class HashHead
    {
        public string hash { get; set; }
    }

    public class sc_message
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    public class Repostmsg: sc_message
    {
        public string hash { get; set; }
    }


    public class err_message
    {
        public int code { get; set; }
        public string message { get; set; }
    }
}



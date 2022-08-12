using System;
using System.Text;
using SharpCompress;
using SharpCompress.Readers;
using SharpCompress.Compressors;
using SharpCompress.Common;
using SharpCompress.Writers;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using SharpCompress.Archives.SevenZip;

namespace Common
{
    public static class CompressHelper
    {

        /// <summary>
        /// 压缩文件/文件夹
        /// </summary>
        /// <param name="filePath">需要压缩的文件/文件夹路径</param>
        /// <param name="zipPath">压缩文件路径（zip后缀）</param>
        /// <param name="filterExtenList">需要过滤的文件后缀名</param>
        public static void CompressionFile(string filePath, string zipPath, List<string> filterExtenList = null)
        {
            try
            {
                using (var zip = File.Create(zipPath))
                {
                    //设置编码格式防止乱码
                    var option = new WriterOptions(CompressionType.Deflate)
                    {
                        ArchiveEncoding = new SharpCompress.Common.ArchiveEncoding()
                        {
                            Default = Encoding.UTF8
                        }
                    };
                    using (var zipWriter = WriterFactory.Open(zip, ArchiveType.Zip, option))
                    {
                        if (Directory.Exists(filePath))
                        {
                            //添加文件夹
                            zipWriter.WriteAll(filePath, "*",
                              (path) => filterExtenList == null ? true : !filterExtenList.Any(d => Path.GetExtension(path).Contains(d, StringComparison.OrdinalIgnoreCase)), SearchOption.AllDirectories);
                        }
                        else if (File.Exists(filePath))
                        {
                            zipWriter.Write(Path.GetFileName(filePath), filePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 压缩（zip格式）
        /// </summary>
        /// <param name="fromFileDirectory">待压缩目录</param>
        /// <param name="outFilePath">压缩后文全件路径</param>
        public static void ZipCompress(string fromFileDirectory, string outFilePath)
        {
            //解决中文乱码问题
            SharpCompress.Common.ArchiveEncoding ArchiveEncoding = new SharpCompress.Common.ArchiveEncoding();
            ArchiveEncoding.Default = Encoding.GetEncoding("utf-8");
            SharpCompress.Writers.WriterOptions options = new SharpCompress.Writers.WriterOptions(CompressionType.Deflate);
            options.ArchiveEncoding = ArchiveEncoding;

            using (var archive = ZipArchive.Create())
            {
                archive.AddAllFromDirectory(fromFileDirectory);
                using (var zip = File.OpenWrite(outFilePath))
                    archive.SaveTo(zip, options);
            }
        }


        #region 解压缩
        /// <summary>
        /// 解压文件
        /// </summary>
        /// <param name="zipPath">压缩文件路径</param>
        /// <param name="dirPath">解压到文件夹路径</param>
        /// <param name="password">密码</param>
        public static void DeCompressionFile(string zipPath, string dirPath, string password = "")
        {
            if (!File.Exists(zipPath))
            {
                throw new ArgumentNullException("zipPath压缩文件不存在");
            }
            Directory.CreateDirectory(dirPath);
            try
            {
                using (Stream stream = File.OpenRead(zipPath))
                {
                    //设置编码格式防止乱码(文件内容和文件名)
                    var option = new ReaderOptions()
                    {
                        ArchiveEncoding = new SharpCompress.Common.ArchiveEncoding()
                        {
                            Default = Encoding.UTF8
                        }
                    };
                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        option.Password = password;
                    }

                    var reader = ReaderFactory.Open(stream, option);
                    while (reader.MoveToNextEntry())
                    {
                        if (reader.Entry.IsDirectory)
                        {
                            Directory.CreateDirectory(Path.Combine(dirPath, reader.Entry.Key));
                        }
                        else
                        {
                            //创建父级目录，防止Entry文件,解压时由于目录不存在报异常
                            var file = Path.Combine(dirPath, reader.Entry.Key);
                            Directory.CreateDirectory(Path.GetDirectoryName(file));
                            reader.WriteEntryToFile(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



      


        /// <summary>
        /// 7Z 速度慢
        /// </summary>
        /// <param name="fromFilePath">待解压文件全路径</param>
        /// <param name="outFileDirectory">解压文件后目录</param>
        public static void Decompress7Z(string fromFilePath, string outFileDirectory)
        {
            var archive = SevenZipArchive.Open(fromFilePath);

            foreach (var entry in archive.Entries)
            {
                entry.WriteToDirectory(outFileDirectory, new ExtractionOptions()
                {
                    ExtractFullPath = true,
                    Overwrite = true
                });
            }
 
        }
        /// <summary>
        /// 解压缩加密的包(支持rar，zip)
        /// </summary>
        /// <param name="fromFilePath"></param>
        /// <param name="outFileDirectory"></param>
        public static  bool Decompress(string fromFilePath, string outFileDirectory)
        {
            var archive = ArchiveFactory.Open(fromFilePath);
            foreach (var entry in archive.Entries)
            {
                if (!entry.IsDirectory)
                {
                    //Debug.WriteLine(entry.Key);
                    entry.WriteToDirectory(outFileDirectory, new ExtractionOptions { ExtractFullPath = true, Overwrite = true });
                }
            }
            archive.Dispose();
            return true;
        }

        /// <summary>
        /// 解压缩加密的包(支持rar，zip)
        /// </summary>
        /// <param name="fromFilePath">待解压文件全路径</param>
        /// <param name="outFileDirectory">解压文件后目录</param>
        /// <param name="password">密码</param>
        public static void DecompressWithPwd(string fromFilePath, string outFileDirectory, string password)
        {
            using (var archive = ArchiveFactory.Open(fromFilePath, new ReaderOptions { Password = password }))
            {
                foreach (var entry in archive.Entries)
                {
                    if (!entry.IsDirectory)
                    {
                        //Debug.WriteLine(entry.Key);
                        entry.WriteToDirectory(outFileDirectory, new ExtractionOptions { ExtractFullPath = true, Overwrite = true });
                    }
                }
            }
        }

        #endregion
    }
}
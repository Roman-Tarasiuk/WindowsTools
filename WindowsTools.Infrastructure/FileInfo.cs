using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace FileInfoEx
{
    public enum FileInfoDetails
    {
        Size = 1,
        MD2 = 2,
        MD4 = 4,
        MD5 = 8,
        SHA1 = 16,
        SHA256 = 32,
        SHA384 = 64,
        SHA512 = 128,
        CreationTime = 256,
        LastAccessTime = 512,
        LastWriteTime = 1024
    }

    public class FileInfoEx
    {
        public static string GetFileInfo(string filePath, FileInfoDetails fi)
        {
            filePath = filePath.Replace("\"", String.Empty);

            StringBuilder result = new StringBuilder(filePath);

            try
            {
                FileInfo fileInfo =
                    (fi & FileInfoDetails.Size) != 0 ||
                    (fi & FileInfoDetails.CreationTime) != 0 ||
                    (fi & FileInfoDetails.LastAccessTime) != 0 ||
                    (fi & FileInfoDetails.LastWriteTime) != 0
                    ? new FileInfo(filePath)
                    : null;

                if ((fi & FileInfoDetails.Size) != 0)
                {
                    result.Append("\tSize:" + fileInfo.Length.ToString());
                }

                using (var stream = File.OpenRead(filePath))
                {
                    // MD5
                    if ((fi & FileInfoDetails.MD5) != 0)
                    {
                        stream.Seek(0, SeekOrigin.Begin);

                        using (var md5 = MD5.Create())
                        {
                            result.Append("\tMD5:" + BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", String.Empty));
                        }
                    }

                    // SHA256
                    if ((fi & FileInfoDetails.SHA256) != 0)
                    {
                        stream.Seek(0, SeekOrigin.Begin);

                        using (var sha256 = SHA256.Create())
                        {
                            result.Append("\tSHA256:" + BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", String.Empty));
                        }
                    }
                }

                if ((fi & FileInfoDetails.CreationTime) != 0)
                {
                    result.Append("\tCreation:" + fileInfo.CreationTime.ToString());
                }

                if ((fi & FileInfoDetails.LastAccessTime) != 0)
                {
                    result.Append("\tLastAccess:" + fileInfo.LastAccessTime.ToString());
                }

                if ((fi & FileInfoDetails.LastWriteTime) != 0)
                {
                    result.Append("\tLastModification:" + fileInfo.LastWriteTime.ToString());
                }

            }
            catch
            {
                throw;
            }

            return result.ToString();
        }

        public static string GetDirectoryInfo(string directoryPath, FileInfoDetails fi)
        {
            directoryPath = directoryPath.Replace("\"", String.Empty);

            var result = new StringBuilder();

            try
            {
                var directories = Directory.EnumerateDirectories(directoryPath);

                foreach (var d in directories)
                {
                    result.Append(GetDirectoryInfo(d, fi));
                }

                var files = Directory.EnumerateFiles(directoryPath);

                foreach (var f in files)
                {
                    result.AppendLine(GetFileInfo(f, fi));
                }
            }
            catch
            {
                throw;
            }

            return result.ToString();
        }

        public static string GetFilesListInfo(string[] files, FileInfoDetails fi)
        {
            var result = new StringBuilder();

            if (files == null)
            {
                throw new ArgumentException();
            }

            try
            {
                for (var i = 0; i < files.Length; i++)
                {
                    result.AppendLine(GetFileInfo(files[i], fi));
                }
            }
            catch
            {
                throw;
            }

            return result.ToString();
        }

        public static string GetFilesListInfo(string filePath, FileInfoDetails fi)
        {
            filePath = filePath.Replace("\"", String.Empty);

            var result = new StringBuilder();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string path;
                    
                    while((path = reader.ReadLine()) != null)
                    {
                        result.AppendLine(GetFileInfo(path, fi));
                    }
                }
            }
            catch
            {
                throw;
            }

            return result.ToString();
        }

        public static void GetDirectoryInfo(string directoryPath, FileInfoDetails fi, string outputFilePath)
        {
            directoryPath = directoryPath.Replace("\"", String.Empty);
            outputFilePath = outputFilePath.Replace("\"", String.Empty);

            try
            {
                using (var writer = new StreamWriter(outputFilePath))
                {
                    writer.Write(GetDirectoryInfo(directoryPath, fi));
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
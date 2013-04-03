using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.FtpClient;
using System.Text;

namespace ChipboxKanalYedek
{
    public static class FTPTools
    {
        public static void UploadFile(string ftpHost, string username, string password, string filepathToUpload, string fileToWrite)
        {
            FtpClient chipbox = new FtpClient();
            chipbox.Host = ftpHost;
            chipbox.Credentials = new NetworkCredential(username, password);

            Stream chipboxDosya = chipbox.OpenWrite(fileToWrite);
            FileStream dosya = new FileStream(filepathToUpload, FileMode.Open);

            try
            {
                int bufferSize = 8192;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = dosya.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    chipboxDosya.Write(buffer, 0, readCount);
                    readCount = dosya.Read(buffer, 0, bufferSize);
                }


            }
            finally
            {
                dosya.Close();
                chipboxDosya.Close();
            }

        }

        public static void DownloadFile(string ftpHost, string username, string password, string fileToDownload, string filepathToWrite)
        {

            FtpClient chipbox = new FtpClient();
            chipbox.Host = ftpHost;
            chipbox.Credentials = new NetworkCredential(username, password);

            Stream chipboxDosya = chipbox.OpenRead(fileToDownload, FtpDataType.Binary);
            FileStream dosya = new FileStream(filepathToWrite, FileMode.Create);

            try
            {
                int bufferSize = 8192;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = chipboxDosya.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    dosya.Write(buffer, 0, readCount);
                    readCount = chipboxDosya.Read(buffer, 0, bufferSize);
                }

            }
            finally
            {

                dosya.Close();
                chipboxDosya.Close();
            }



        }
    }
}

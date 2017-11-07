using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace ChatBot
{
    public class Updater
    {
        public void Main()
        {
            string botFilePath = "https://www.dropbox.com/s/obdvfhar78lfhkq/ChatBot.exe";
            int urlLength = botFilePath.Length;
            string botVersionPath = @"F:\\ChatBot\\VersionInfo.txt";

            try
            {
                AssemblyName AssemblyName = new AssemblyName();
                AssemblyName.Version = new Version("0.9");
                WebRequest request = WebRequest.Create(botVersionPath);
                request.Method = "POST";
                WebResponse response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());

                string newestVersion = sr.ReadToEnd();
                var currentVersion = Convert.ToString(AssemblyName.Version);

                if (newestVersion.Contains(currentVersion))
                {
                    Console.WriteLine("You are up to date!");

                }
                else if (!newestVersion.Contains(currentVersion))
                {
                    
                    WebClient WebClient = new WebClient();
                    WebClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                    for (int urlIndex = 0; urlIndex < urlLength; urlIndex++)
                    {
                        Console.Write(botFilePath[urlIndex]);
                        System.Threading.Thread.Sleep(50);

                    }
                
                    WebClient.DownloadDataAsync(new Uri(botFilePath), @"C:\\Users\\lord - _000\\Desktop\\ChatBot.exe");

                    Console.WriteLine(newestVersion);
                    AssemblyName.Version = new Version(newestVersion);
                    Console.WriteLine(AssemblyName.Version);


                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Something went wrong ;w;" + "\r\n" +
                    ex);
            }
        }
        void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            int counter = 0;
            counter++;

            if (counter % 500 == 0)
            {
                Console.WriteLine("Download "
                    + ((e.BytesReceived / 1024f) / 1024f).ToString("#0.##") + "mb"
                    + " of "
                    + ((e.TotalBytesToReceive / 1024f) / 1024f).ToString("#0.##") + "mb"
                    + " (" + e.ProgressPercentage + "%)"
            );
            }
        }
    }
    }


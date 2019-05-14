using System;
using System.IO;
using System.Net;
using System.Threading;

namespace http_downloader
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Starting dowload.........");
            MakeUrlList(args); //Test reading from file
            Console.ReadLine();
			Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
		}
		
		public static void DownloadOne(string[] urlList, string output, int maxspeed)
		{
			WebClient webcl = new WebClient();
			//
		}
		
		public static void DownloadAll (int threads)
		{
			//
		}
		
		public static string[] MakeUrlList(string[] args)
		{
            // First argument is a filename with list of urls

            if (args.Length != 0)
            {
                string[] urls = File.ReadAllLines(args[0]);

                // Test log urls to console output

                for (int i = 0; i < urls.Length; ++i)
                    Console.WriteLine(urls[i]);
                return urls;
            }
            else return null;
		}

        public static Boolean CheckArgs(string[] args)
        {
            int.TryParse(args[0], out int threadCount);
            int.TryParse(args[1], out MainInput.Speed);
            string path = args[2];
            string folder = args[3];
            if ( (args.Length == 4) 
                    && (threadCount >=1)
                    && (speed >=1)
               )
                return true;
            else return false;
        }

    }
}
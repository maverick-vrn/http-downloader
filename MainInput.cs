using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;

namespace http_downloader
{
    class MainInput

    {
        private string file_path;
        private int speed;
        private string folder;

        public string GetFilePath()
        {
            return file_path;
        }

        public void SetSpeed()
        {
            string spd = Console.ReadLine();
            int.TryParse(spd, out speed);
        }

        public int GetSpeed()
        {
            return speed;
        }


    }
}

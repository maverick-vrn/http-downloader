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
        string file_path;
        int speed;
        string folder;

        string getFilePath()
        {
            return file_path;
        }

        void setSpeed()
        {
            string spd = Console.ReadLine();
            Int32.TryParse(spd, out speed);
        }

        int getSpeed()
        {
            return speed;
        }


    }
}

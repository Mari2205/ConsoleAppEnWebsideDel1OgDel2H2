using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppEnWebsideDel1OgDel2H2
{
    class FileRequest : IRequest
    {
        public void GetRequest(string userUrl)
        {
            string text = File.ReadAllText(@".\The file for the program.txt");
            Console.WriteLine(text);
        }
    }
}

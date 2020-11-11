using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleAppEnWebsideDel1OgDel2H2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ui ui = new Ui();
            WebRequest webRequest = new WebRequest();
            FileRequest fileRequest = new FileRequest();

            string[] choicesOfTheUser = { "Webside Request from url", "File Request"};

            ui.SetMenuHeading();
            ui.SetMenuBody(choicesOfTheUser);
            Console.Write("Chose a number : ");
            int usrNum = int.Parse(Console.ReadLine());

            switch (usrNum)
            {
                case 1:
                    Console.Write("Enter you´re URL : ");
                    string usrUrl = Console.ReadLine();
                    Console.Clear();
                    ui.GetLoadingSequence("Pleace wait while the URL is loading");
                    Console.Clear();
                    ui.GetLoadingSequence("Printing");

                    webRequest.GetRequest(usrUrl);
                    break;
                case 2:
                    Console.Write("Enter you´re file path´s : ");
                    string usrFile = Console.ReadLine();
                    Console.Clear();
                    ui.GetLoadingSequence("Pleace wait while the URL is loading");
                    Console.Clear();
                    ui.GetLoadingSequence("Printing");

                    fileRequest.GetRequest(usrFile);
                    break;
                default:
                    Console.WriteLine("Pleace, enter a valid number");
                    break;
            }

            Console.ReadKey();
        }
    }
}

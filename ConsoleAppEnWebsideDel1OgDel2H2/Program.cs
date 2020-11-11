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

            string[] choicesOfTheUser = { "Webside Request from url" };


            ui.SetMenuHeading();
            ui.SetMenuBody(choicesOfTheUser);

            int usrNum = int.Parse(Console.ReadLine());
            Console.Write("Enter you´re URL : ");
            string usrUrl = Console.ReadLine();

            Console.Clear();
            ui.GetLoadingSequence("Pleace wait while the URL is loading");
            Console.Clear();
            ui.GetLoadingSequence("Printing");



            switch (usrNum)
            {
                case 1:
                    webRequest.GetRequest(usrUrl);
                    break;
                default:
                    Console.WriteLine("Pleace, enter a valid number");
                    break;
            }


            Console.ReadKey();
        }
    }
}

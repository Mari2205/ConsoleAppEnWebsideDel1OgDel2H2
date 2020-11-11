using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleAppEnWebsideDel1OgDel2H2
{
    class Ui
    {
        public void SetMenuHeading()
        {
            string acsiiMenu = @"                
$$$$$$\$$$$\   $$$$$$\  $$$$$$$\  $$\   $$\ 
$$  _$$  _$$\ $$  __$$\ $$  __$$\ $$ |  $$ |
$$ / $$ / $$ |$$$$$$$$ |$$ |  $$ |$$ |  $$ |
$$ | $$ | $$ |$$   ____|$$ |  $$ |$$ |  $$ |
$$ | $$ | $$ |\$$$$$$$\ $$ |  $$ |\$$$$$$  |
\__| \__| \__| \_______|\__|  \__| \______/
";

            Console.WriteLine(acsiiMenu);
        }

        public void SetMenuBody(string[] listOfChoices)
        {
            int numbering = 1;
            foreach (string choices in listOfChoices)
            { 
                Console.WriteLine(numbering + ") " + choices.ToString());
                numbering++;
            }
        }

        public void GetLoadingSequence(string loadingText)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(loadingText);
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);

                Console.Clear();
            }
            Console.WriteLine();
        
        }
    }
}

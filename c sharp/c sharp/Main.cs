using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace c_sharp
{
    class Programm{
        public static void Main(string[] args){
            bool isWorking = true;
            while(isWorking)
            {
                Console.WriteLine("1-Rādīt informāciju par muziku");
                Console.WriteLine("2-Meklējiet informāciju par albomus");
                Console.WriteLine("3-Mūzikas meklēšana pēc žanra");
                Console.WriteLine("4-Add new files");
                Console.WriteLine("5-Informācija par lietotājiem programma");
                Console.WriteLine("6-Programmas iziešana");
                Console.WriteLine("Tava izvēle:");
                int number;
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Kāda ir tava mīļākā mūzika");
                        string str = Console.ReadLine();
                        switch (str)
                        {
                            case "As it was":
                                Console.WriteLine("This perfect msuic");
                                //xml2.music();
                                break;
                            case "Envolver":
                                Console.WriteLine("This great msuic");
                                break;
                            case "Plan A":
                                Console.WriteLine("This middlie msuic");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Kāda ir tava mīļākā alboms");
                        string str2 = Console.ReadLine();
                        switch (str2)
                        {
                            case "Soda Luv":
                                Console.WriteLine("This perfect msuic");
                                //xml1.alboms();
                                break;
                            case "Mayot":
                                Console.WriteLine("This great msuic");
                                //read1.XMLread();
                                break;
                            case "Miyagi & Andy Panda":
                                Console.WriteLine("This middlie msuic");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Kāda veida mūziku vēlaties meklēt pēc žanra");
                        string str3 = Console.ReadLine();
                        switch (str3)
                        {
                            case "Tautas mūzika":
                                //xml3.songs();
                                Console.WriteLine("No tautas mūzikas es ieteiktu 'Tu esi mans dārgais'");
                                break;
                            case "Lego":
                                Console.WriteLine("No tautas mūzikas es ieteiktu 'Hit the Road Jack. Ray Charles '");
                                //read3.XMLread_songs();
                                break;
                            case "Romans":
                                Console.WriteLine("No tautas mūzikas es ieteiktu 'Maijpuķīte'");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Add albom name:");
                        string albomName = Console.ReadLine();
                        string sgrg = Console.ReadLine();
                        Alboms.AddAlbom(albomName, sgrg);
                        break;
                    case 5:
                        Console.WriteLine("Kuru lietotāju vēlaties atrast?");
                        string str4 = Console.ReadLine();
                        switch (str4)
                        {
                            case "1 lietotajs":
                                Console.WriteLine("Informacis par 1 lietotajs");
                                Console.WriteLine("Name:Edgars");
                                Console.WriteLine("Surname:Jansons");
                                Console.WriteLine("Email:Jansons8797@gmail.com");
                                Console.WriteLine("Telephons:45123854");
                                //read2.XMLread_music();
                                break;
                            case "2 lietotajs":
                                Console.WriteLine("Informacis par 2 lietotajs");
                                Console.WriteLine("Name:Andris");
                                Console.WriteLine("Surname:Kalniņš");
                                Console.WriteLine("Email:Andris9435@gmail.com");
                                Console.WriteLine("Telephons:94856713");
                                break;
                            case "3 lietotajs":
                                Console.WriteLine("Informacis par 3 lietotajs");
                                Console.WriteLine("Name:Juris");
                                Console.WriteLine("Surname:Ozoliņš");
                                Console.WriteLine("Email:Juris3476@gmail.com");
                                Console.WriteLine("Telephons:68123782");
                                break;
                        }
                        break;
                    case 6:
                        isWorking = false;
                        break;
                }
            }
        }
            
}
}
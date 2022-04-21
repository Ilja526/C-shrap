using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace Base{
    class Programm{
        public static void Main(string[] args){
            Console.WriteLine("1-Rādīt informāciju par muziku");
            Console.WriteLine("2-Meklējiet informāciju par alboms");
            Console.WriteLine("3-Mūzikas meklēšana pēc žanra");
            Console.WriteLine("4-Informācija par lietotājiem programma");
            Console.WriteLine("5-Programmas iziešana");
            Console.WriteLine("Tava izvēle:");
            Programm3 xml1;
            Programm5 xml2;
            Programm7 xml3;
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            switch(number){
                case 1:
                   Console.WriteLine("Kāda ir tava mīļākā mūzika");
                   string str = Console.ReadLine();
                        switch(str){
                            case "As it was":
                                Console.WriteLine("This perfect msuic");
                                xml2.music();
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
                             switch(str2){
                                case "Soda Luv":
                                    Console.WriteLine("This perfect msuic");
                                    xml1.alboms();
                                    break;
                                case "Mayot":
                                    Console.WriteLine("This great msuic");
                                    break;
                                case "Miyagi & Andy Panda":
                                    Console.WriteLine("This middlie msuic");
                                    break;
                           }
                           break;
                    case 3:
                        Console.WriteLine("Kāda veida mūziku vēlaties meklēt pēc žanra");
                        string str3 = Console.ReadLine();
                             switch(str3){
                                case "Tautas mūzika":
                                    xml3.songs();
                                    Console.WriteLine("No tautas mūzikas es ieteiktu 'Tu esi mans dārgais'");
                                    break;
                                case "Jaz":
                                    Console.WriteLine("No tautas mūzikas es ieteiktu 'Hit the Road Jack. Ray Charles '");
                                    break;
                                case "Romans":
                                    Console.WriteLine("No tautas mūzikas es ieteiktu 'Maijpuķīte'");
                                    break;
            }
            break;
                    case 4:
                        Console.WriteLine("Kuru lietotāju vēlaties atrast?");
                        string str4 = Console.ReadLine();
                             switch(str4){
                                case "1 lietotajs":
                                    Console.WriteLine("Informacis par 1 lietotajs");
                                    Console.WriteLine("Name:Edgars");
                                    Console.WriteLine("Surname:Jansons");
                                    Console.WriteLine("Email:Jansons8797@gmail.com");
                                    Console.WriteLine("Telephons:45123854");
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
                    case 5:
                        Console.WriteLine("Jūs esat ārpus šīs programmas");
                        break;
        }
    }
}
}

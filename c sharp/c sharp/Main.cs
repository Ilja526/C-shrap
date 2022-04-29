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
                Console.WriteLine("6-Parāda informāciju par failiem");
                Console.WriteLine("7-Programmas iziešana");
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
                        switch (str3)
                        {
                            case "Tautas mūzika":
                                Console.WriteLine("No tautas mūzikas es ieteiktu 'Tu esi mans dārgais'");
                                break;
                            case "Lego":
                                Console.WriteLine("No tautas mūzikas es ieteiktu 'Hit the Road Jack. Ray Charles'");
                                break;
                            case "Romans":
                                Console.WriteLine("No tautas mūzikas es ieteiktu 'Maijpuķīte'");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Add albom datus:");
                        string albomName = Console.ReadLine();
                        string word = Console.ReadLine();
                        Alboms.AddAlbom(albomName, word);
                        break;
                    case 5:
                        Console.WriteLine("Kuru lietotāju vēlaties atrast?");
                        string str4 = Console.ReadLine();
                        switch (str4)
                        {
                            case "1 lietotajs":
                                Console.WriteLine("Ko vēlaties pievienot 1 lietotājam?");
                                string objekts = Console.ReadLine();
                                string name = Console.ReadLine();
                                string surname = Console.ReadLine();
                                string status = Console.ReadLine();
                                string email = Console.ReadLine();
                                Addmusic.music(objekts, name, surname, status, email);
                                break;
                            case "2 lietotajs":
                                Console.WriteLine("Ko vēlaties pievienot 2 lietotājam?");
                                string objekts = Console.ReadLine();
                                string name = Console.ReadLine();
                                string surname = Console.ReadLine();
                                string status = Console.ReadLine();
                                string email = Console.ReadLine();
                                Addmusic2.music2(objekts, name, surname, status, email);
                                break;
                            case "3 lietotajs":
                                Console.WriteLine("Ko vēlaties pievienot 3 lietotājam?");
                                string objekts = Console.ReadLine();
                                string name = Console.ReadLine();
                                string surname = Console.ReadLine();
                                string status = Console.ReadLine();
                                string email = Console.ReadLine();
                                Addmusic3.music3(objekts, name, surname, status, email);
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Kuru failu vēlaties atlasīt skatīšanai?");
                        string str5 = Console.ReadLine();
                        switch(str5)
                        {
                            case "alboms.cs":
                                ReadAlboms.XMLread();
                                break;
                            case "music.cs":
                                ReadMusic.XMLread_music();
                                break;
                            case "songs.cs":
                                ReadSongs.XMLread_songs();
                        }
                    case 7:
                        isWorking = false;
                        break;
                }
            }
        }
            
}
}

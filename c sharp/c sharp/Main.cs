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
                        string str6 = Console.ReadLine();
                        switch(str6)
                        {
                            case "alboms.cs":
                                  Console.WriteLine("Add albom datus:");
                                  string objetext6 = Console.ReadLine();
                                  string idtext6 = Console.ReadLine();
                                  string nametext6 = Console.ReadLine();
                                  string album_artisttext6 = Console.ReadLine();
                                  string yeartext6 = Console.ReadLine();
                                  string zanrstext6 = Console.ReadLine();
                                  Alboms.AddAlbom(objetext6, idtext6, nametext6, album_artisttext6, yeartex6, zanrstext6);
                                  break;
                            case "songs.cs":
                                  Console.WriteLine("Add songs datus:");
                                  string objetext7 = Console.ReadLine();
                                  string idtext7 = Console.ReadLine();
                                  string nametext7 = Console.ReadLine();
                                  string album_artisttext7 = Console.ReadLine();
                                  string yeartext7 = Console.ReadLine();
                                  string zanrstext7 = Console.ReadLine();
                                  Songs.songs((objetext7, idtext7, nametext7, album_artisttext7, yeartex7, zanrstext7);
                        }
                    case 5:
                        Console.WriteLine("Kuru lietotāju vēlaties atrast?");
                        string str4 = Console.ReadLine();
                        switch (str4)
                        {
                            case "1 lietotajs":
                                Console.WriteLine("Ko vēlaties pievienot 1 lietotājam?");
                                string objekts1 = Console.ReadLine();
                                string name1 = Console.ReadLine();
                                string surname1 = Console.ReadLine();
                                string status1 = Console.ReadLine();
                                string email1 = Console.ReadLine();
                                Addmusic.music(objekts1, name1, surname1, status1, email1);
                                break;
                            case "2 lietotajs":
                                Console.WriteLine("Ko vēlaties pievienot 2 lietotājam?");
                                string objekts2 = Console.ReadLine();
                                string name2 = Console.ReadLine();
                                string surname2 = Console.ReadLine();
                                string status2 = Console.ReadLine();
                                string email2 = Console.ReadLine();
                                Addmusic2.music2(objekts2, name2, surname2, status2, email2);
                                break;
                            case "3 lietotajs":
                                Console.WriteLine("Ko vēlaties pievienot 3 lietotājam?");
                                string objekts3 = Console.ReadLine();
                                string name3 = Console.ReadLine();
                                string surname3 = Console.ReadLine();
                                string status3 = Console.ReadLine();
                                string email3 = Console.ReadLine();
                                Addmusic3.music3(objekts3, name3, surname3, status3, email3);
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
                                break;
                        }
                        break;
                    case 7:
                        isWorking = false;
                        break;
                }
            }
        }
            
}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;
namespace xmlread_songs{
    class Programm20{
        protected:
            XDocument xdoc;
            XElement? songs;
    }
    class Programm21:protected Programm20{
        public:
            void XMLread_songs(){
                XDocument xdoc = XDocument.Load("songs.xml");
                XElement? songs = xdoc.Element("songs");
                if(songs is not null){
                    foreach(XElement information in songs.Elements("information")){
                        XElement? objekts = information.Element("objekts");
                        XElement? id = information.Element("id");
                        XElement? name = information.Element("name");
                        XElement? time = information.Element("time");
                        XElement? artist = information.Element("artist");

                        Console.WriteLine($"Objekts: {objekts?.Value}");
                        Console.WriteLine($"Id: {id?.Value}");
                        Console.WriteLine($"Name: {name?.Value}");
                        Console.WriteLine($"Time: {time?.Value}");
                        Console.WriteLine($"Artist: {artist?.Value}");
                    }
                }
            }
    } 
}
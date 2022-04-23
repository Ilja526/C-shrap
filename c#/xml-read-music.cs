using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;
namespace xmlread_music{
    class Programm15{
        protected:
            XDocument xdoc;
            XElement? music;
    }
    class Programm16:protected Programm15{
        public:
            void XMLread_music(){
                XDocument xdoc = XDocument.Load("music.xml");
                XElement? music = xdoc.Element("music");
                if(music is not null){
                    foreach (XElement information in music.Elements("information")){
                        XElement? objekts = information.Element("objekts");
                        XElement? id = information.Element("id");
                        XElement? name = information.Element("name");
                        XElement? surname = information.Element("surname");
                        XElement? status = information.Element("status");
                        XElement? email = information.Element("email");
 
                        Console.WriteLine($"Objekts: {objekts?.Value}");
                        Console.WriteLine($"Id: {id?.Value}");
                        Console.WriteLine($"Name: {name?.Value}");
                        Console.WriteLine($"Surname: {surname?.Value}");
                        Console.WriteLine($"Status: {status?.Value}");
                        Console.WriteLine($"Email: {email?.Value}");
 
                        Console.WriteLine();
                    }
                }
            }
    } 
}

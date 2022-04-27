using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;
namespace c_sharp
{
    class Programm15{
        protected XDocument xdoc;
        protected XElement music;
    }
    class Programm16 : Programm15{
            public void XMLread_music(){
                XDocument xdoc = XDocument.Load("../../../Data/music.xml");
                XElement music = xdoc.Element("music");
                if(music != null){
                    foreach (XElement information in music.Elements("information")){
                        XElement objekts = information.Element("objekts");
                        XElement id = information.Element("id");
                        XElement name = information.Element("name");
                        XElement surname = information.Element("surname");
                        XElement status = information.Element("status");
                        XElement email = information.Element("email");
 
                        Console.WriteLine($"Objekts: {objekts.Value}");
                        Console.WriteLine($"Id: {id.Value}");
                        Console.WriteLine($"Name: {name.Value}");
                        Console.WriteLine($"Surname: {surname.Value}");
                        Console.WriteLine($"Status: {status.Value}");
                        Console.WriteLine($"Email: {email.Value}");
 
                        Console.WriteLine();
                    }
                }
            }
    } 
}

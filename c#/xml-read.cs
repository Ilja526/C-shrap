using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;
namespace xmlread{
    class Programm10{
        protected:
            XDocument xdoc;
            XElement? alboms;
    }
    class Programm11:protected Programm10{
        public:
            void XMLread(){
                XDocument xdoc = XDocument.Load("alboms.xml");
                XElement? alboms = xdoc.Element("alboms");
                if(alboms is not null){
                    foreach(XElement information in alboms.Elements("information")){
                        XElement? objekts = information.Element("objekts");
                        XElement? id = information.Element("id");
                        XElement? album_artists = information.Element("album_artists");
                        XElement? year = information.Element("year");
                        XElement? zanrs = information.Element("zanrs");
 
                        Console.WriteLine($"Objekts: {objekts?.Value}");
                        Console.WriteLine($"Id: {id?.Value}");
                        Console.WriteLine($"Album_artists: {album_artists?.Value}");
                        Console.WriteLine($"Year: {year?.Value}");
                        Console.WriteLine($"Zanrs: {zanrs?.Value}");
 
                        Console.WriteLine();
                    }
                }
            }
    }
  }
}
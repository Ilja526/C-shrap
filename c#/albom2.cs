using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace xmlfails{
    class Programms2{
        protected:
            XmlDocument xmlDocu;
        protected:
            XmlElement informatElem;
            XmlElement nameElem;
            XmlElement albumElem;    
    }
    class Programm3:protected Programms2{
        public:
            void alboms(){
                XmlDocument xmlDocu = new XmlDocument();
                xmlDocu.Load("albom.xml");
                XmlElement? xRoot = xmlDocu.DocumentElement;

                XmlElement informatElem = xmlDocu.CreateElement("information");

                XmlElement nameElem = xDoc.CreateElement("name");
                XmlElement album_artistElem = xmlDocu.CreateElement("albom");

                XmlText nameText = xDoc.CreateTextNode("Ilja");
                XmlText album_artistText = xmlDocu.CreateTextNode("HARDIN");

                nameElem.AppendChild(nameText);
                album_artistElem.AppendChild(albumText);

                informatElem.AppendChild(nameElem);
                informatElem.AppendChild(album_artistElem);

                xRoot?.AppendChild(informatElem);

                xmlDocu.Save("albom.xml");
            }
    }
}

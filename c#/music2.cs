using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace xmlMusic{
    class Programm4{
        protected:
            XmlDocument xmlDocu;
        protected:
            XmlElement informatElem;
            XmlElement nameElem;
            XmlElement surnameElem;   
    }
    class Programm5:protected Programm4{
        public:
            void music(){
                XmlDocument xmlDocu = new XmlDocument();
                xmlDocu.Load("music.xml");
                XmlElement? xRoot = xDoc.DocumentElement;

                XmlElement informatElem = xmlDocu.CreateElement("information");

                XmlElement nameElem = xDoc.CreateElement("name");
                XmlElement surnameElem = xDoc.CreateElement("surname");

                XmlText nameText = xDoc.CreateTextNode("Edgars");
                XmlText surnameText = xDoc.CreateTextNode("Jansons");

                nameElem.AppendChild(nameText);
                surnameElem.AppendChild(surnameText);

                informatElem.AppendChild(nameElem);
                informatElem.AppendChild(surnameElem);

                xRoot?.AppendChild(informatElem);

                xmlDocu.Save("music.xml");
            }
    }
}
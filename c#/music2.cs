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

                XmlElement nameElem = xmlDocu.CreateElement("name");
                XmlElement surnameElem = xmlDocu.CreateElement("surname");

                XmlText nameText = xmlDocu.CreateTextNode("Edgars");
                XmlText surnameText = xmlDocu.CreateTextNode("Jansons");

                nameElem.AppendChild(nameText);
                surnameElem.AppendChild(surnameText);

                informatElem.AppendChild(nameElem);
                informatElem.AppendChild(surnameElem);

                xRoot?.AppendChild(informatElem);

                xmlDocu.Save("music.xml");
            }
    }
}

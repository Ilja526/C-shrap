using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace c_sharp
{
    class Programm4{
        
        protected XmlDocument xmlDocu;
        protected XmlElement informatElem;
        protected XmlElement nameElem;
        protected XmlElement surnameElem;

        public void music(string filename)
        {
            XmlDocument xmlDocu = new XmlDocument();
            xmlDocu.Load(filename);
            XmlElement xRoot = xmlDocu.DocumentElement;

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

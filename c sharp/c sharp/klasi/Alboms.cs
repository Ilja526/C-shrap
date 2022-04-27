using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace c_sharp
{
    class Alboms
    {
        protected XmlDocument xmlDocu;
        protected XmlElement informatElem;
        protected XmlElement nameElem;
        public void alboms()
        {
            XmlDocument xmlDocu = new XmlDocument();
            xmlDocu.Load("albom.xml");
            XmlElement xRoot = xmlDocu.DocumentElement;

            XmlElement informatElem = xmlDocu.CreateElement("information");

            XmlElement nameElem = xmlDocu.CreateElement("name");
            XmlElement album_artistElem = xmlDocu.CreateElement("albom");

            XmlText nameText = xmlDocu.CreateTextNode("Ilja");
            XmlText album_artistText = xmlDocu.CreateTextNode("HARDIN");

            nameElem.AppendChild(nameText);
            album_artistElem.AppendChild(album_artistText);

            informatElem.AppendChild(nameElem);
            informatElem.AppendChild(album_artistElem);

            xRoot?.AppendChild(informatElem);

            xmlDocu.Save("albom.xml");
        }
    }
}

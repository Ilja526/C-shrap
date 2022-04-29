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
        public static void AddAlbom(string objetext, string idtext, string nametext, string album_artisttext, string yeartext, string zanrstext)
        {
            XmlDocument xmlDocu = new XmlDocument();
            xmlDocu.Load("../../../Data/alboms.xml");
            XmlElement xRoot = xmlDocu.DocumentElement;

            XmlElement informatElem = xmlDocu.CreateElement("information");

            XmlElement objeElem = xmlDocu.CreateElement("objekts");
            XmlElement idElem = xmlDocu.CreateElement("id");
            XmlElement nameElem = xmlDocu.CreateElement("name");
            XmlElement album_artistElem = xmlDocu.CreateElement("album_artists");
            XmlElement yearElem = xmlDocu.CreateElement("year");
            XmlElement zanrsElem = xmlDocu.CreateElement("zanrs");

            XmlText objeText = xmlDocu.CreateTextNode(objetext);
            XmlText idText = xmlDocu.CreateTextNode(idtext);
            XmlText nameText = xmlDocu.CreateTextNode(nametext);
            XmlText album_artistText = xmlDocu.CreateTextNode(album_artisttext);
            XmlText yearText = xmlDocu.CreateTextNode(yeartext);
            XmlText zanrsText = xmlDocu.CreateTextNode(zanrstext);

            objeElem.AppendChild(objeText);
            idElem.AppendChild(idText);
            nameElem.AppendChild(nameText);
            album_artistElem.AppendChild(album_artistText);
            yearElem.AppendChild(album_artistText);
            zanrsElem.AppendChild(zanrsText);
            
            informatElem.AppendChild(objeElem);
            informatElem.AppendChild(idElem);
            informatElem.AppendChild(nameElem);
            informatElem.AppendChild(album_artistElem);
            informatElem.AppendChild(yearElem);
            informatElem.AppendChild(zanrsElem);

            xRoot.AppendChild(informatElem);

            xmlDocu.Save("../../../Data/alboms.xml");
        }
    }
}

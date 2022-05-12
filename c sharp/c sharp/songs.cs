using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace c_sharp
{
    class Programm56{
        protected XmlDocument xmlDocu;
        protected XmlElement informatElem;
        protected XmlElement nameElem;
        protected XmlElement surnameElem;   
    }
    class Programm7 : Programm56{
        
        public static void songs(string objetext, string idtext, string nametext, string song_timetext, string song_artisttext){
            XmlDocument xmlDocu = new XmlDocument();
            xmlDocu.Load("../../../Data/songs.xml");
            XmlElement xRoot = xmlDocu.DocumentElement;

            XmlElement informatElem = xmlDocu.CreateElement("information");

            XmlElement objeElem = xmlDocu.CreateElement("objekts");
            XmlElement idElem = xmlDocu.CreateElement("id");
            XmlElement nameElem = xmlDocu.CreateElement("name");
            XmlElement song_timeElem = xmlDocu.CreateElement("song_time");
            XmlElement song_artistElem = xmlDocu.CreateElement("song_artist ");
          
            XmlText objeText = xmlDocu.CreateTextNode(objetext);
            XmlText idText = xmlDocu.CreateTextNode(idtext);
            XmlText nameText = xmlDocu.CreateTextNode(nametext);
            XmlText song_timeText = xmlDocu.CreateTextNode(song_timetext);
            XmlText song_artistText = xmlDocu.CreateTextNode(song_artisttext);

            objeElem.AppendChild(objeText);
            idElem.AppendChild(idText);
            nameElem.AppendChild(nameText);
            song_timeElem.AppendChild(song_timeText);
            song_artistElem.AppendChild(song_artistText);
         
            informatElem.AppendChild(objeElem);
            informatElem.AppendChild(idElem);
            informatElem.AppendChild(nameElem);
            informatElem.AppendChild(song_timeElem);
            informatElem.AppendChild(song_artistElem);

            xRoot.AppendChild(informatElem);

            xmlDocu.Save("../../../Data/songs.xml");
            }
    }
}

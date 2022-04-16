using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace xmlAlboms{
    class Programm6{
        protected:
            XmlDocument xmlDocu;
        protected:
            XmlElement informatElem;
            XmlElement nameElem;
            XmlElement surnameElem;   
    }
    class Programm7:protected Programm6{
        public:
            void songs(){
                XmlDocument xmlDocu = new XmlDocument();
                xmlDocu.Load("songs.xml");
                XmlElement? xRoot = xDoc.DocumentElement;

                XmlElement informatElem = xmlDocu.CreateElement("information");

                XmlElement song_timeElem = xDoc.CreateElement("song_time");
                XmlElement song_artistElem = xDoc.CreateElement("song_artist ");

                XmlText song_timeText = xDoc.CreateTextNode("dziesmas laiks ");
                XmlText song_artistText = xDoc.CreateTextNode("dziesmas Autors");

                song_timeElem.AppendChild(song_timeText);
                song_artistElem.AppendChild(song_artistText);

                informatElem.AppendChild(song_timeElem);
                informatElem.AppendChild(song_artistElem);

                xRoot?.AppendChild(informatElem);

                xmlDocu.Save("songs.xml");
            }
    }
}
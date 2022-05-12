using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace c_sharp
{
    class Programm6{
        
        protected XmlDocument xmlDocu;
        protected XmlElement informatElem;
        protected XmlElement nameElem;
        protected XmlElement surnameElem;

        public static void music2(string objetext, string idtext, string nametext, string surnametext, string statutext, string emailtext)
        {
            XmlDocument xmlDocu = new XmlDocument();
            xmlDocu.Load("../../../Data/music2.xml");
            XmlElement xRoot = xmlDocu.DocumentElement;

            XmlElement informatElem = xmlDocu.CreateElement("information");
            
            XmlElement objeElem = xmlDocu.CreateElement("objekts");
            XmlElement idElem = xmlDocu.CreateElement("id");
            XmlElement nameElem = xmlDocu.CreateElement("name");
            XmlElement surnameElem = xmlDocu.CreateElement("surname");
            XmlElement statuElem = xmlDocu.CreateElement("status");
            XmlElement emailElem = xmlDocu.CreateElement("email");
            
            XmlText objeText = xmlDocu.CreateTextNode(objetext);
            XmlText idText = xmlDocu.CreateTextNode(idtext);
            XmlText nameText = xmlDocu.CreateTextNode(nametext);
            XmlText surnameText = xmlDocu.CreateTextNode(surnametext);
            XmlText statuText = xmlDocu.CreateTextNode(statutext);
            XmlText emailText = xmlDocu.CreateTextNode(emailtext);
            
            objeElem.AppendChild(objeText);
            idElem.AppendChild(idText);
            nameElem.AppendChild(nameText);
            surnameElem.AppendChild(surnameText);
            statuElem.AppendChild(statuText);
            emailElem.AppendChild(emailText);
            
            informatElem.AppendChild(objeElem);
            informatElem.AppendChild(idElem);
            informatElem.AppendChild(nameElem);
            informatElem.AppendChild(surnameElem);
            informatElem.AppendChild(statuElem);
            informatElem.AppendChild(emailElem);

            xRoot.AppendChild(informatElem);

            xmlDocu.Save("../../../Data/music2.xml");
        }
    }
}

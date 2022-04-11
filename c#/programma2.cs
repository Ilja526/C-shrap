using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace xmlfails{
    class Programms2{
        public static void Main(string[] args){
            XmlDocument xDocu = new XmlDocument();
            xDocu.Load("text.xml");
            XmlElement? xRoot = xDocu.DocumentElement;

            XmlElement informElem = xDocu.CreateElement("information");
 
            XmlElement nameElem = xDocu.CreateElement("name");
            XmlElement surnameElem = xDocu.CreateElement("surname");
            XmlElement emailElem = xDocu.CreateElement("email");
 
            XmlText nameText = xDocu.CreateTextNode("Edgars");
            XmlText surnameText = xDocu.CreateTextNode("Jansons");
            XmlText emailText = xDocu.CreateTextNode("Jansons8797@gmail.com");
 
            nameAttr.AppendChild(nameText);
            surnameElem.AppendChild(surnameText);
            emailElem.AppendChild(emailText);
 
            informElem.Attributes.Append(nameAttr);
            informElem.AppendChild(surnameElem);
            informElem.AppendChild(emailElem);
            xRoot?.AppendChild(informElem);

            xDocu.Save("text.xml");
        }
    }
}

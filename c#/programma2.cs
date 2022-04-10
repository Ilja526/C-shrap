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
            XmlElement? xRoot = xDoc.DocumentElement;

            XmlElement informElem = xDoc.CreateElement("information");
 
            XmlElement nameElem = xDoc.CreateElement("name");
            XmlElement surnameElem = xDoc.CreateElement("surname");
            XmlElement emailElem = xDoc.CreateElement("email");
 
            XmlText nameText = xDoc.CreateTextNode("Edgars");
            XmlText surnameText = xDoc.CreateTextNode("Jansons");
            XmlText emailText = xDoc.CreateTextNode("Jansons8797@gmail.com");
 
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

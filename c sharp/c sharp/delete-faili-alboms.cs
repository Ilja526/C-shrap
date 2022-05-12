using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace c_sharp{
    class Programm65{
        protected XmlDocument xDoc;
        protected XmlElement xRoot;
        protected XmlNode firstNode;

        public static void delete_faile_alboms(){
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../../Data/alboms.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode firstNode = xRoot.FirstChild;
            if(firstNode != null){
                xRoot.RemoveChild(firstNode);
            }  
            xDoc.Save("../../../Data/alboms.xml");
        }
    }
}

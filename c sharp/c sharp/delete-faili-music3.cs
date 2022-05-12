using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace c_sharp{
    class Programm71{
        protected XmlDocument xDoc;
        protected XmlElement xRoot;
        protected XmlNode firstNode;

        public static void delete_faile_music3(){
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../../Data/music3.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode firstNode = xRoot.FirstChild;
            XmlNode secondNode = xRoot.SecondChild;
            XmlNode thirdNode = xRoot.ThirdChild;
            XmlNode fourthNode = xRoot.FourthChild;
            XmlNode fifthNode = xRoot.FifthChild;
            XmlNode sixthNode = xRoot.SixthChild;
            if(firstNode != null){
                xRoot.RemoveChild(firstNode);
            }
            if(secondNode != null){
                xRoot.RemoveChild(secondNode);
            }  
            if(thirdNode != null){
                xRoot.RemoveChild(thirdNode);
            }  
            if(fourthNode != null){
                xRoot.RemoveChild(fourthNode);
            }
            if(fifthNode != null){
                xRoot.RemoveChild(fifthNode);
            }  
            if(sixthNode != null){
                xRoot.RemoveChild(sixthNode);
            }  
            xDoc.Save("../../../Data/music.xml");
        }
    }
}

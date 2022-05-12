using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace c_sharp{
    class Programm60{
        //Šos mainīgos aizsargā protected funkcija, tāpēc tiem var piekļūt, tikai izmantojot metodi.
        protected XmlDocument xDoc;
        protected XmlElement xRoot;
        protected XmlNode firstNode;

        public static void delete_faile_music(){
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../../Data/music.xml");//Šeit mēs norādām ceļu uz failu, ierakstot tā nosaukumu.
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode firstNode = xRoot.FirstChild;
            if(firstNode != null){ //Šeit, izmantojot operatoru if, mēs pārbaudām, vai failā ir mezgli vai nav.
                xRoot.RemoveChild(firstNode);
            }
            xDoc.Save("../../../Data/music.xml");
        }
    }
}

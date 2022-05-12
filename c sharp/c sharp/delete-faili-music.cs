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
            XmlNode secondNode = xRoot.SecondChild;
            XmlNode thirdNode = xRoot.ThirdChild;
            XmlNode fourthNode = xRoot.FourthChild;
            XmlNode fifthNode = xRoot.FifthChild;
            XmlNode sixthNode = xRoot.SixthChild;
            if(firstNode != null){ //Šeit, izmantojot operatoru if, mēs pārbaudām, vai failā ir mezgli vai nav.
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

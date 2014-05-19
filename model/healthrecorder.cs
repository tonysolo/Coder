using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace coder.model
{
    class healthrecorder
    {

        //public setup Setup {get; set;}
        public List<visit> Visits { get; set; }
        public List<template> Templates { get; set; }
        public List<region> Regions { get; set; }
        public usersettings Setup { get; set; }

        public healthrecorder()
        {
            Visits = new List<visit>();
            Templates = new List<template>();
            Regions = new List<region>();
            Setup = new usersettings();
        }

        public void LoadFile()
        {
            throw new System.NotImplementedException();
        }

        public void SaveFile()
        {
            throw new System.NotImplementedException();
        }

        public void ExportTemplates(string filename)
        {

        }

        public void ImportTemplates(string filename)
        {
            throw new System.NotImplementedException();
        }


        public void ExportRegions(string filename)
        {
            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            using (XmlTextWriter xtw = new XmlTextWriter(sw))
            using (StreamWriter stw = new StreamWriter(filename))
            {
                xtw.WriteStartElement("coderregions");
                for (int i = 0; i < Regions.Count; i++)
                {
                    xtw.WriteStartElement("r");
                    xtw.WriteString(Regions[i].ToString());
                    xtw.WriteEndElement();
                }
                xtw.WriteEndElement();
                stw.Write(sb.ToString());

            }

        }

        public void ImportRegions(string filename)
        {
   using(StreamReader sr = File.OpenText(filename))
   using(XmlTextReader xtr  = new XmlTextReader(sr))
   {
       xtr.Read();
       if  (xtr.Name != "coderregions") return;
       XmlReader subtree = xtr.ReadSubtree();
       while (subtree.Read())
           if (subtree.Name == "r") 
           { subtree.Read();
             Regions.Add(new region(subtree.Value)); 
           }
        }
    }
    }
}

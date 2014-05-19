using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
   

   public class Shortcut:VT_base,ICloneable
    {
       //public pdata PData { get; set; }
        //public List<string> ICDs { get; set; } //= new List<string>();
        //public List<string> Tarifs { get; set; }
     // List <string> DescTarifs;
     // List <string> DescICDs;

       public string Name { get; set; }

       public Shortcut()
       { 
       
       }
       
        public Shortcut(Visit v)
        {
            bitdata = v.bitdata;
            ICDs = v.ICDs;
            Tariffs = v.Tariffs;
           this.Name = "template";
        }

        public Shortcut(string str)
        {
            string[] dat = str.Split(',');
            Tariffs = dat[0].Split(' ');//.ToList<string>();
            ICDs = dat[1].Split(' ');//.ToList<string>();
           // this.DescTarifs = dat[2].Split(' ').ToList<string>();
           // this.DescICDs = dat[3].Split(' ').ToList<string>();
            Name = dat[2];
            //this regionname needed to describe coords
        }

        public override string ToString() //used to display fields, not for filing
        {
            string[] dat = new string[5];
            dat[0] = Name;
            return String.Join(",", dat);
        }

       public object Clone()
        {
            Shortcut sc = new Shortcut();
            sc.Tariffs = this.Tariffs;
            sc.ICDs = this.ICDs;
            sc.bitdata = this.bitdata;
            sc.referer_region_coords = this.referer_region_coords;
            sc.treater_region_coords = this.treater_region_coords;
            sc.Name = this.Name;
            return (object)sc;
        }   
            
    }

   
}

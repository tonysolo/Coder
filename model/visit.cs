using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    //DATA record - csv with 4 records
    //HHHHHHHHHHH comma 11 char (44bit) hex number for patient details
    //icd10 codes (space delimted then comma)
    //tariff codes (space delimited then comma)
    //provider id (not diplayed)
    //filepos (not diplayed)

   // VisitStatus (not sent to cloud - local info only)
    //0x01 = sent (synchronised)
    //0x02 = include additional icd codes
    //0x04 = include tariff codes


    public class Visit : VT_base,ICloneable
    {        
        public Coderdate date {get;set;}
        public UInt16 Loader = 0;
        public byte VisitStatus = 0; 
                                
 

        /// <summary>
        ///constructs visit from csv with date depending on length.  
        /// </summary>
        /// <param name="st">csv</param>
        public Visit(string st)
        {
            string[] str = st.Split(',');

            switch (str[0].Length)
            {
                case 22: date = new Coderdate();
                    bitdata=new BitData(str[0]); break;
                case 26: date.days = Convert.ToInt16(str[0].Substring(0, 4));
                    bitdata=new BitData(str[0].Substring(4, 22)); break;
                case 31: date.days = Convert.ToInt16(str[0].Substring(5, 4));
                    bitdata = new BitData(str[0].Substring(9, 22)); break;
            }          
            this.ICDs = str[1].Split(' ');
            this.Tariffs = str[2].Split(' ');;
        }
           
      
        public Visit()
        {
            date = new Coderdate();
            bitdata = new BitData();
            ICDs = new string[5];
            Tariffs = new string[5];

        }


        public Visit(Shortcut t)
        {
            date = new Coderdate();
            this.bitdata = t.bitdata;
            this.ICDs = t.ICDs;
            this.Tariffs = t.Tariffs;          
        }


       new public string ToDisplay()
        {
            return
            date.ToString() + ',' +
            base.ToDisplay();
        }
        public override string ToString()
        {
            return
            Loader.ToString("X5") +
            date.ToString() +
            base.ToString();
        }
        public object Clone() 
        {
            Visit vs = new Visit();
            vs.Tariffs = this.Tariffs;
            vs.ICDs = this.ICDs;
            vs.bitdata = this.bitdata;
            vs.referer_region_coords = this.referer_region_coords;
            vs.treater_region_coords = this.treater_region_coords;
            vs.date = this.date;
            return (object) vs;
        }
    }
}

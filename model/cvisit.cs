using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    //DATA record - csv with 3 records
    // 34 character 136 bit hex number for patient details
    //icd10 codes (space delimted then comma)
    //tariff codes (space delimited then comma)
    //provider id (not diplayed)

    public class cvisit : ICloneable
    {
        public string ICDs { get; set; }
        // public string Tariffs { get; set; }
        public Visit Bitdata { get; set; }
        // public cDate Date { get { return Bitdata.date; } } //set { Bitdata.date.dateTime = value; }}\\\\\\\\
        public byte tag { get; set; }
        public string Name { get; set; }
        public string TreatRegion { get; set; }
        public string PatientRegion { get; set; }
        public byte order { get; set; } //calculated runtime to display the order after sorting by date
        //tag: saved and synched=0 not_synched=1(@) not_saved=2(#) (@ or # prepended to name)
        //---------------------------------------------------------
        /// <summary>
        ///constructs visit from csv with date depending on length.  
        /// </summary> 
        /// <param name="st">csv</param>
        public cvisit(string st)
        {
            char[] delim = { ',' };
            string[] str = st.Split(delim);
            this.Name = str[0];
            this.Bitdata = new model.Visit(str[1]);
            this.ICDs = str[2];
            //this.Tariffs = str[3];
            // this.TreatPlaceName = str[4];
            // this.ReferPlaceName = str[5];
        }
        //---------------------------------------------------
        public cvisit()
        {
            //Name = "No_Name";
            Name = "Fit Boy";
            cDate _date = new cDate();
            string s = _date.ToString();
            //Bitdata = new Visit();
            Bitdata = new Visit("139C00000000000000138625");
            ICDs = "Z00.2";
            //Tariffs = "";
            //TreatPlaceName = "";
            //ReferPlaceName = "";
        }

        //Bitdata = new BitData(str_bitdata);

        //----------------------------------------------------
        public override string ToString()
        {
            return
            this.Name + ',' +
            this.Bitdata.ToString() + ',' +
            this.ICDs;// +',' +
            //this.Tariffs + ',' +
            //this.TreatPlaceName;//+ ',' +
            //this.ReferPlaceName;
        }
        //------------------------------------------------------
        public object Clone()
        {
            cvisit vs = new cvisit(this.ToString());
            return (object)vs;
        }

        //-------------------------------------------------------
    }
}


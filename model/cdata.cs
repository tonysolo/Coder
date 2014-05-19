using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;

namespace coder.model
{
//---------------------------------------------------------------
    public class preference
    {
        public byte language { get; set; }
        public byte vote { get; set;}

//-----------------------------------------------------------------

        public preference(string str) 
        {
            byte b = Convert.ToByte(str,16);
            language = (byte)((b & 0xFC)>>2); //6bit
            vote = (byte)(b & 0x03);          //2bit    
        }

//----------------------------------------------------------------

        public override string ToString()
        {
            return ((language << 2) | vote).ToString("X2");
        }   
    }
//-------------------------------------------------------------
    /// <summary>    
    ///  converts a byte to race , gender, in-outpat, age group 
    /// </summary>
    public class patient
    {
      public byte race { get; set; }
      public  bool male { get; set; }
      public  bool out_patient { get; set; }
      public  byte age_group { get; set; }

//---------------------------------------------------------
      public patient() { } 

//--------------------------------------------------------

        public patient(string str)
        {
        byte b = Convert.ToByte(str, 16);
        age_group = (byte)(b & 0x0F);  //4bits
        out_patient = ((b & 0x10) != 0); //1bit
        male = ((b & 0x20) != 0);        //1bit
        race = (byte)((b & 0xC0) >> 6);   //2bits //8 bits
        }
//-----------------------------------------------------------------

        public override string ToString()
        {
         byte b = (byte)(age_group | (race << 6));
         if (male == true) b = (byte)(b | 0x20);
         if (out_patient == true) b = (byte)(b | 0x10);
         return b.ToString("X2");
        }

        //------------------------------------------------------
    }
    /// <summary>
    /// converts a byte to bool pvt-pub clinic type
    /// </summary>
        public class clin
        {
            public byte pvt{get;set;}
            public byte type{get;set;}

//------------------------------------------------
            public clin() { }
//--------------------------------------------------

            public clin(string str)
            {
                byte b = Convert.ToByte(str, 16);
                type = (byte)(b & 0x07);
                pvt =  (byte)((b & 0x08)>>3);
            }
//-------------------------------------------------------

            public override string ToString()
            {
                return  (type | (pvt<<3)).ToString("X1");
            }
        }
    //---------------------------------------------------
    /// <summary>
    /// converts byte to qualif and special interest
    /// </summary>
        public class provider
        {
            public byte qualif { get; set; }
            public byte spec_int { get; set; }

            public provider() { }
            public provider(string str) 
            {
                byte b = Convert.ToByte(str, 16);
                qualif = (byte)(b & 0x7);
                spec_int = (byte)((b & 0xF8)>>3);
            }

//---------------------------------------------------

        public override string ToString()
        {
        byte r = (byte)( qualif | (spec_int <<3));
        return r.ToString("X2");
        }
        }

//-----------------------------------------------   
public class cdata
{   
public cdate date {get;set;} //4

//public cRegion treaterCoord { get; set; }  //7
public cRegion patientCoord { get; set; }  //7
//public clin referer_clinic { get; set; }       //1 
public clin treater_clinic { get; set; }    //1
public provider treater { get; set; }       //2
//public provider referer { get; set; }          //2
public patient patient {get;set;}           //2
public preference preference { get; set; }  //2
public byte coderversion { get; set; }      //1
public UInt16 LoaderID { get; set; }        //5   //total 31 characters
   
//loaderid and loader coordinate and preference could go into json header
//replace treatercoordinate with nsew offset byte = msb = 0 if no offset 
//this will reduce the cdata to 20 characters and add a common loader header of 14 characters
//-----------------------------------------------------------

public cdata(string str) // 31 character hex string
{
date = new cdate(str.Substring(0,4));
//byte treatercoordoffset;
//treaterCoord = new cRegion(str.Substring(4,7)); //treatCoord.HexValue = str.Substring(4,7);
patientCoord = new cRegion(str.Substring(11,7)); //referCoord.HexValue = str.Substring(11,7);
treater_clinic = new clin(str.Substring(18,1));
//referer_clinic = new clin(str.Substring(19,1));
treater = new provider(str.Substring(19,2));
//referer = new provider(str.Substring(22,2));
patient = new patient (str.Substring(21,2));
//preference = new preference(str.Substring(23,2));
//coderversion = Convert.ToByte(str.Substring(25,1),16);
//LoaderID = Convert.ToUInt16(str.Substring(26,4),16);//?needs 32bit
}

 //then icd codes (space sep), tariff codes (space sep)
//public BitData(){}-----------------------------------

public override string ToString()
{
    string s =

    date.ToString() +
        //treaterCoord.HexValue +
    patientCoord.HexValue +
    treater_clinic.ToString() +
        //referer_clinic.ToString() +
    treater.ToString() +
        //referer.ToString() +
    patient.ToString();
//preference.ToString() +
//coderversion.ToString("X1") + 
//LoaderID.ToString("X4");
//int x = s.Length;
return s;
} 
//------------------------------------------------------
}

public class GHGRow 
{
    public UInt32 loaderID; 
    public cRegion loaderCoord;
    public preference vote;
    public byte coderversion;
    public cdata[] p { get; set; }
}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;
//using Newtonsoft.Json.Serialization;
//using Newtonsoft.Json.Utilities;

namespace coder.model
{
//---------------------------------------------------------------
   // public class preference
   // {
        //public byte language { get; set; }
    //    public byte vote { get; set;}

//-----------------------------------------------------------------

      //  public preference(string str) 
     //   {
      //      byte b = Convert.ToByte(str,16);
            //language = (byte)((b & 0xFC)>>2); //6bit
      //      vote = (byte)(b & 0x03);          //2bit    
       // }

//----------------------------------------------------------------

  //      public override string ToString()
   //     {
            //return ((language << 2) | vote).ToString("X2")
  //          return vote.ToString("X2");
   //     }   
    //}
//-------------------------------------------------------------
    /// <summary>    
    ///  converts a byte to race , gender, in-outpat, age group 
    /// </summary>
    public class Patient
    {
      //public cRegion coord { get; set; }
      public byte race { get; set; }
      public  bool male { get; set; }
      public  bool out_patient { get; set; }
      public  byte age_group { get; set; }
     

//---------------------------------------------------------
      public Patient() { } 

//--------------------------------------------------------

        public Patient(string str)
        {
            //todo add region 
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
        public class Clinic
        {
            public byte pvt{get;set;}
            public byte type{get;set;}
            public byte count { get; set;}

//------------------------------------------------
            public Clinic() { count = 1; }
//--------------------------------------------------

            public Clinic(string str)
            {
                Int16 b = Convert.ToInt16(str, 16);
                type = (byte)(b & 0x07);
                pvt =  (byte)((b & 0x08)>>3);
                count = (byte)((b & 0xF0) >> 4);
            }
//-------------------------------------------------------

            public override string ToString()
            {
                return  (type | (pvt<<3) | count<<4).ToString("X2");
            }
        }
    //---------------------------------------------------
    /// <summary>
    /// converts byte to qualif and special interest
    /// </summary>
        public class Treater
        {
           // public cRegion coord { get; set; }
            public byte qualif { get; set; }
            public byte spec_int { get; set; }

            public Treater() { }
            public Treater(string str) 
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

        public class epidem_rec 
        {
            public cRegion treaterCoord { get; set; }  //7
            public cRegion patientCoord { get; set; }  //7
            public Clinic  treater_clinic { get; set; }    //2
            public Treater treater { get; set; }       //2
            public Patient patient { get; set; }           //2

            public epidem_rec(string str)//string20
            {
treaterCoord = new cRegion(str.Substring(0,7)); //0,7
patientCoord = new cRegion(str.Substring(7,7)); //7,7
treater_clinic = new Clinic(str.Substring(14,2)); //14,2

treater = new Treater(str.Substring(16,2));//16,2

patient = new Patient (str.Substring(18,2));//18,2    
            }
        
        }

//-----------------------------------------------   
public class Visit
{   
public cDate date {get;set;} //4

public epidem_rec epirec { get; set; }
//public cRegion treaterCoord { get; set; }  //7
//public cRegion patientCoord { get; set; }  //7
//public Clinic treater_clinic { get; set; }    //2
//public Treater treater { get; set; }       //2
//public Patient patient {get;set;}           //2

//public preference preference { get; set; }  //2
//public byte coderversion { get; set; }      //1
//public UInt16 LoaderID { get; set; }        //5  
//xxxxxxxxxxxxxxxxxxxxxxx //total 23 characters 
//xxx xxx xxx             //plus icd (+-10)
   
//loaderid and loader coordinate and preference could go into json header
//replace treatercoordinate with nsew offset byte = msb = 0 if no offset 
//this will reduce the cdata to 20 characters and add a common loader header of 14 characters
//-----------------------------------------------------------

public Visit(string str) // 31 character hex string
{
date = new cDate((str.Length>3)? str.Substring(0,4):null);
//byte treatercoordoffset;
//treaterCoord = new cRegion();
epirec = new epidem_rec(str.Substring(4,20));
//treaterCoord = (str.Length<11)? new cRegion() :new cRegion(str.Substring(4,7)); //0,7
//patientCoord = (str.Length<18)? new cRegion() :new cRegion(str.Substring(11,7)); //7,7
//treater_clinic = (str.Length<19)?new Clinic(): new Clinic(str.Substring(18,2)); //14,2
//referer_clinic = new clin(str.Substring(19,1));
//treater = (str.Length<21)?new Treater() : new Treater(str.Substring(20,2));//16,2
//referer = new provider(str.Substring(22,2));
//patient = (str.Length<23)?new Patient(): new Patient (str.Substring(22,2));//18,2
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
    epirec.treaterCoord.HexValue +
    epirec.patientCoord.HexValue +
    epirec.treater_clinic.ToString() +
        //referer_clinic.ToString() +
    epirec.treater.ToString() +
        //referer.ToString() +
    epirec.patient.ToString();
    
//preference.ToString() +
//coderversion.ToString("X1") + 
//LoaderID.ToString("X4");
//int x = s.Length;
return s;
} 
//------------------------------------------------------
}

//public class Loader
//{ }

public class Loader 
{

public Loader(cRegion region, uint id, byte vote, byte version)
    {
        _loadercoord = region;
        _loaderid = id;
        _vote = vote;
        _coderversion = version;
    }

public string LoaderSettings
{
get
    {
    return
     _loadercoord.CompactHexValue
    +_loaderid.ToString("X:5")
    + _vote.ToString("X:1")
    + _coderversion.ToString("X:1");
    }

    set
    {
    _loadercoord = new cRegion(value.Substring(0,5));
    _loaderid = Convert.ToUInt32(value.Substring(5,5),16);
    _vote = (byte)value[10];
    _coderversion= (byte)value[11];
  

    } 
}

//[JsonProperty(PropertyName = "v")]
public string[] Visits
{
get 
    {
    string[] s = new string[_visits.Length];
    for (int i = 0; i < s.Length; i++) s[i] = _visits[i].ToString();
    return s;
    }
set 
    { 
    _visits = new Visit[value.Length];
    for (int i = 0; i < _visits.Length; i++) _visits[i] = new Visit(value[i]);      
    }
}

private UInt32 _loaderid; //20 bits hex string
private cRegion _loadercoord; //20 bits
private byte _vote;  //4 bits used
private byte _coderversion;  //4bits used

private Visit[] _visits { get; set; }



public string[] loaderDataRow() 
{
    string[] sarr = new string[Visits.Length + 1];
    sarr.SetValue(LoaderSettings,0);
    sarr.SetValue(Visits,1);
    return sarr;
}

public string jsonDataRow()
{
//string[] s = LoaderDataRow();
return JsonConvert.SerializeObject(loaderDataRow());
//return str;
}  
    
}
}


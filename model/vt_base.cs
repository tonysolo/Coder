using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
public  class VT_base // : ICloneable
    {
//private UInt16 _loader = 0;
public Coordinate treater_region_coords { get;set;}
public Coordinate referer_region_coords { get;set;}
//public coderdate date {get;set;}
public BitData bitdata { get; set; }
public string[] ICDs {get;set;}
public string[] Tariffs {get;set;}

//public string Loader 
//{
//get{return _loader.ToString("X5");}
//set{_loader = Convert.ToUInt16(value, 16);}
//}

public VT_base()
{
treater_region_coords = new Coordinate();
referer_region_coords  = new Coordinate();
bitdata = new BitData();
ICDs = new string[0];
Tariffs = new string[0];
}

public VT_base(string str)//fixed length (tlocation,rlocation,date,pdata,loader) -- 
                             //variable length icd10 list |tarrifs list
{
    string[] s_arr = str.Split(',');
    UInt32 x = Convert.ToInt32(s_arr[0].Substring.Substring(0,7),16);
    treater_region_coords = new Coordinate(x);
          x = Convert.ToInt32(s_arr[0].Substring.Substring(7, 7), 16);  
    referer_region_coords = new Coordinate(s_arr[0].Substring(7,7),16);
       date = new coderdate(s_arr[0].Substring(14,4));
    //todo need to check here getbytes
    ulong x = Convert.ToUInt64(s_arr[0].Substring(Substring(14)),16);
    byte[] b = BitConverter.GetBytes(x); 
       bitdata = new BitData(b);// should be 6 byte / 12 charters
    //Loader = s_arr[0].Substring(22,5);
    ICDs = s_arr[1].Split(' ');
    Tariffs = s_arr[2].Split(' ');
}

//object Clone() 
//{
 //   VT_base vt = new VT_base();
 //   vt.bitdata = this.bitdata;
 //   vt.ICDs = this.ICDs;
 //   vt.Tariffs = this.Tariffs;
 //   vt.referer_region_coords = this.referer_region_coords;
//    vt.treater_region_coords = this.treater_region_coords;
//    return (object)vt;
//}


public override string ToString()
{
    
}


public string ToDisplay()
{
return
treater_region_coords.ToDisplay() + "," +
referer_region_coords.ToDisplay() + "," +
bitdata.ToString() + "," +
String.Join(" ",ICDs) + "," +
String.Join(" ",Tariffs);
}



}

        } 

                                                                


   


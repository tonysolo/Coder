using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{

static public class RegionUtil
{
private UInt16 lat,lon;
private byte ns;
const float arc26 = 4096/180F;


private void ConvertToInt(string coords)
{
float la, lo; 
char[] ca = { ' ',',' };
string[] sarr = coords.Split(ca);
    if (sarr.Length == 2)
    {
        la = Convert.ToSingle(sarr[0]);//*arc26;
        lo = Convert.ToSingle(sarr[1]);
    }

    else la = lo =  0;
  
        ns = (byte)((la < 0) ? 2 : 0);
        ns = (byte)((lo < 0) ? (ns | (byte)1) : ns);
        lat = (ushort)Math.Round(Math.Abs(la) * arc26);
        lon = (ushort)Math.Round(Math.Abs(lo) * arc26);  

}

//-------------------------------------------------
//private ToLowRes(string coords) //the usual google
//{
 //   char[] ca = { ' ',',' };
  //  string[] sarr = coords.Split(ca);
  //  if (sarr.Length == 2)
  //  {
  //      la = Convert.ToSingle(sarr[0])*arc26;
   //     lo = Convert.ToSingle(sarr[1])*arc26;
  //  }

   // else la = lo =  0;
    //{

       // UInt32 x = Convert.ToUInt32(coords, 16);
        //byte ns = (byte)((x >> 24) | 0x3);
        //UInt16 lattit = (UInt16)((x >> 12) | 0xfff);
       // UInt16 longit = (UInt16)(x | 0xfff);
       // la = (lattit * arc26);
        //lo = (longit) * arc26;
       // la = ((ns | 1) > 0) ? la * -1 : la;
        //lo = ((ns | 2) > 0) ? lo * -1 : lo;
    //}

//-----------------------------------------------------
//-------------------------------------------------------

//-------------------------------------------------------
//public LowResRegion(UInt32 x) //low res coordinate - takes the 28bit (7 char Hexadecimal)
//{
//byte ns = (byte)((x >> 24) | 0x3); 
//UInt16 lattit = (UInt16)((x >> 12) | 0xfff);
//UInt16 longit = (UInt16)(x | 0xfff);
//la = (lattit * arc26);
//lo = (longit) * arc26;
//la =  ((ns|1) > 0)? la*-1:la;
//lo =  ((ns|2) > 0)? lo*-1:lo;
//}
//---------------------------------------------------------


public static string TwelveBitHexValue(string coords)//used for 7 character treater referrer coodinates
{
    ConvertToInt(coords);
      return String.Format("{0:X1}{1:X3}{2:X3}", ns, lat, lon); 
        //UInt32 ret = (UInt32)(ns << 25);
        //       ret = ((ret | lat) << 12);
         //      ret = (ret | lon);
          //    return ret.ToString("X7");
}  

//----------------------------------------------------------


public static string EightBitHexValue(string coords)  //used for compact 5 char foldername in s3
{
ConvertToInt(coords);
return String.Format("{0:X1}{1:X2}{2:X2}", ns, lat, lon);
}
//-------------------------------------------------------------------

//public string DetailName()//? remove and store this in coder file as standard +- coordinates 4 dec precision
//{
//float N = la;
//float E = lo;
//if (la<0) NS[0]='S';
//if (lo<0) NS[1]='W';
//return String.Format("{0}{1},{2}{3}",
//Math.Abs(N).ToString("F2"),
//NS[0],
//Math.Abs(E).ToString("F2"),
//NS[1]);

//--------------------------------------------------------------
//public string ToDisplay()
//{
//    return Name+","+DisplayName+","+ HexName;
//}

public string Border(string coords)
{
  
        ConvertToInt(coords);
       
        string lat0 = (lat / arc26).ToString("F4");
        string lat1 = ((lat + 1) / arc26).ToString("F4");
        string lon0 = (lon / arc26).ToString("F4");
        string lon1 = ((lon + 1) / arc26).ToString("F4");
        return String.Format("{0},{2}|{0},{3}|{1},{2}|{1},{3}", lat0, lat1, lon0, lon1);
    }
}
//----------------------------------------------------------------
//public override string ToString()
//{
//    return
//        this.la.ToString("F3") + "," +
 //       this.lo.ToString("F3");
//}
//--------------------------------------------------------------
}


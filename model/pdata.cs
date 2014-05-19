using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
  public  class bitdata
    {
UInt32 _pdata;

public UInt16 treater_region_coords { get;set;}
public UInt16 referer_region_coords { get;set;}


public byte pracstats {get; set; }
public byte coderversion { get; set; }
public byte treater_spec_interest { get; set; } 
public byte referer_spec_interest { get; set; }
public byte treater_qualif  { get; set; }
public byte referer_qualif { get; set; }       
public byte treater_work_condit {get; set;}
public byte referer_work_condit{ get; set; }
public byte race{ get;set;}
public byte age{get;set;}
public byte gender{get;set;}  

public bitdata(string str)
{
_pdata = (UInt32)Convert.ToInt32(str,16);
FillProperties(_pdata);

}

public bitdata(UInt32 _pd)
{
_pdata = _pd;
FillProperties(_pdata);
}

private void FillProperties(UInt32 _pd)
{
//filename

//dateoffset init16;
//treater_coords_msbNS  = UInt16;
//treater NSEW byte //2bits

//treater_region_coords =  (UInt16)((_pd >> 34) & (UInt32)0xFFF);//12 bits
//referer_region_coords =  (UInt16)((_pd >> 22) & (ulong)0xFFF);//12 bits


pracstats             = (byte)((_pd >> 30) & (UInt32)0x03); //2bits//whats this?
coderversion          = (byte)((_pd >> 28) & (UInt32)0x03); //2bits
treater_spec_interest = (byte)((_pd >> 23) & (UInt32)0x1F); //5bits                                                               //5 bit special interest
referer_spec_interest = (byte)((_pd >> 18) & (UInt32)0x1F); //5bits
treater_qualif =      (byte)((_pd >> 15) & (UInt32)0x07);//3 bit qualificatopns
referer_qualif =      (byte)((_pd >> 12) & (UInt32)0x07);//3 bits
treater_work_condit = (byte)((_pd >> 9) & (UInt32)0x07);//3bits  //3 bit work conditions
referer_work_condit = (byte)((_pd >> 6) & (UInt32)0x07); //3bits
age =                 (byte)((_pd >> 3) & (UInt32)0x07); //3bits   
race =                (byte)((_pd >> 1) & (UInt32)0x03);//2bits
gender =              (byte)(_pd  & (UInt32)0x01);//1bit      //total 32bits
}
       
//public pdata();

public override string ToString()
{ UInt32 x = 
    (uint)(gender & 0x01) |
    ((uint)(race & 0x03) << 1) |
    ((uint)(age & 0x07) << 3) |
    ((uint)(referer_work_condit & 0x07) << 6) |
    ((uint)(treater_work_condit & 0x07) << 9) |
    ((uint)(referer_qualif & 0x07) << 12) |
    ((uint)(treater_qualif & 0x07) << 15) |
    ((uint)(referer_spec_interest & 0x1F) << 18) |
    ((uint)(treater_spec_interest & 0x1F) << 23) |
    ((uint)(coderversion & 0x03) << 28) |
    ((uint)(pracstats & 0x03) << 30);
    //return String.Format("{0:X8}",x);
    return x.ToString("X8");
}

        } //DDDDCRTcrSAG date c=countries regions 
                          //specialties types age gender



                      //37bit used

        //0000000000000000000000000000000000000000
//1 gender 0x1
//3-2 Race 0x3 <<1
//7-4 age 0xf << 3
 //0x3 << 7
 //0x3 << 9
 //0x7<< 12    
//0x7<< 15
//0xf <<18
 //0xf <<22
//0x3f<<28
//0x3f<<34


  }                                                              


   


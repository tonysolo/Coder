using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace coder.model
{

public class cRegion : INotifyPropertyChanged
    {

public event PropertyChangedEventHandler PropertyChanged;
private UInt16 lat,lon;
private byte ns;
const float arc26 = 4096/180F;
private string _coords; // centre value of cource

//------------------------------------------------------------------
//hexvalue or  google coords(csv)
//hexvalue will construct low resolution object for border and leave coodinates == null and name ==null
//csv coordinites will construct high resolution version - border plus centre marker mapping 

public cRegion() 
{
    PlaceName = null;
    _coords = null;
    lat = lon = 0;
}



public cRegion(string coords) 
{
float la=0, lo=0;
 
char[] ca = {' ',','};
string[] sarr = coords.Split(ca);
   
switch (sarr.Length)
{
case 3:
        {
        PlaceName = sarr[0];
        Coordinates = sarr[1] + ',' + sarr[2];
       // la = Convert.ToSingle(sarr[1]);//*arc26;
       // lo = Convert.ToSingle(sarr[2]);
            break;
        }
case 2:
        {
            Coordinates = sarr[0] + ',' + sarr[1];
        //la = Convert.ToSingle(sarr[0]);//*arc26;
        //lo = Convert.ToSingle(sarr[1]);
        break;
    }

    case 1:
        {
            UInt32 x = Convert.ToUInt32(sarr[0], 16);
            lon = (UInt16)(x & 0xFFF);
            lat = (UInt16)((x>>12)& 0xFFF);
            ns  = (byte)((x>>24)& 0x03);
            _coords = null;

//la = lo = 0;
        break;
    }
    }

    ns = (byte)((la < 0) ? 2 : 0);
    ns = (byte)((lo < 0) ? (ns | (byte)1) : ns);
    lat = (ushort)Math.Round((Math.Abs(la) * arc26));
    lon = (ushort)Math.Round((Math.Abs(lo) * arc26));    
}

//--------------------------------------------------------------------

    private void NotifyPropertyChanged(String info)
{
    if (PropertyChanged != null)
    {
        PropertyChanged(this, new PropertyChangedEventArgs(info));
    }
}

//------------------------------------------------------------------------

public string Coordinates { 

get { return _coords; }
set
{
_coords = value;
char[] c = new char[]{','};
string[] sarr = _coords.Split(c);
float la = Convert.ToSingle(sarr[0]);
float lo = Convert.ToSingle(sarr[1]);
ns = (byte)((la < 0) ? 2 : 0);
ns = (byte)((lo < 0) ? (ns | (byte)1) : ns);
lat = (ushort)Math.Round((Math.Abs(la) * arc26));
lon = (ushort)Math.Round((Math.Abs(lo) * arc26)); 
NotifyPropertyChanged("Coordinates");                                        
}
} 
   
//-----------------------------------------------------------------------------
//local region name for user record
public string PlaceName { get; set; }                                                       

//------------------------------------------------------------------------------
//gv data 2.6 arc.min resolution
public string HexValue { get { return String.Format("{0:X1}{1:X3}{2:X3}", ns, lat, lon); } } 

//-------------------------------------------------------------------------------
//s3 folder name

public string CompactHexValue {get{return String.Format("{0:X1}{1:X2}{2:X2}", ns, lat, lon); }} 
//-------------------------------------------------------------------------------

public string Border
{
    get
    {
        string lat0 = (lat / arc26).ToString("F4");
        string lat1 = ((lat + 1) / arc26).ToString("F4");
        string lon0 = (lon / arc26).ToString("F4");
        string lon1 = ((lon + 1) / arc26).ToString("F4");
        string str = String.Format("{0},{2}|{0},{3}|{1},{3}|{1},{2}", lat0, lat1, lon0, lon1);
        return str;
    }
}
//------------------------------------------------------------------------------------


    public override string ToString()
    {
    return (PlaceName+','+Coordinates);   
    }
//------------------------------------------------------------------------------------

}
}

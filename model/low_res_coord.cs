using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    class low_res_coord
    {   
        //used for foldername in s3
        //5 hex characters long - a,b,c,d,e
        //a  = 2bits: 0 = ne, 1= nw, 2 = se, 3 = sw
        //bc = 8bits: northings 64 km resolution
        //de = 8bits: eastings 64 km resolution
        byte _ns;
        byte _e;
        byte _n;


        public low_res_coord(UInt32 coord)  
        {
            UInt16 la = (UInt16)((coord>>16) & 0x7ff);
            UInt16 lo = (UInt16)(coord & 0xfff);
            
            _ns = (byte)(((la & 0x8000) >> 14) | ((lo & 0x8000) >> 15));
            _e = (byte)((lo >> 4) & 0xff);  //ew long
            _n = (byte)((la >> 4) & 0xff);  //ns latt
           
        }

       public low_res_coord(string hexstr)  
        {
            //hexstr must be 5 hex characters
            _ns = Convert.ToByte(hexstr.Substring(0,1),16); // 0 1 2 3 ne,nw,se,sw   == 00 01 10 11
             _n = Convert.ToByte(hexstr.Substring(1,2),16); // 8 bit northing
             _e = Convert.ToByte(hexstr.Substring(3),16);   // 8 bit easting    
        }


        public override string ToString()
        {
            return String.Format("x", _ns, _n, _e);
        }
    }
}

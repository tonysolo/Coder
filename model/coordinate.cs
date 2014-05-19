using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{



    public class Coordinate
    {
        public string stcoord
        {
            get
            {
                return la.ToString("F3") + "," +
                       lo.ToString("F3");
            }
            set
            {
                _stcoord = value;
                char[] ch = { ',' };
                string[] sarr = value.Split(ch);
                la = Convert.ToSingle(sarr[0]);//*arc26;
                lo = Convert.ToSingle(sarr[1]);
            }
        }
        public string Name { get; set; }
        const float arc26 = 4096 / 180F;// 12bit arc-minute scaling factor
        //private UInt16 lattit,longit;
        //private byte ns;
        private string _stcoord;
        private float la, lo;

        public Coordinate() { }
        //private void calc_lat_long(string NS, string EW)
        public Coordinate(string NS, string EW)
        {
            la = Convert.ToSingle(NS);//*arc26;
            lo = Convert.ToSingle(EW);// *arc26; //convert to float arc minutes
            //ns = 0x00;
            //if (la<0) ns = (byte)(ns | 0x02); // 00=NE; 01=NW; 10 = SE; 11=SW
            //if (lo<0) ns = (byte)(ns | 0x01);

            //lattit = Convert.ToUInt16(Math.Round(Math.Abs(la)));//Math.Abs(la*10)));
            //longit = Convert.ToUInt16(Math.Round(Math.Abs(lo)));//Math.Abs(lo*10)));
        }

        public Coordinate(float NS, float EW)
        // takes usual format decimal degrees
        {
            la = NS;
            lo = EW;
        }



        public Coordinate(UInt32 x)
        {
            byte ns = (byte)((x >> 24) | 0x3);
            UInt16 lattit = (UInt16)((x >> 12) | 0xfff);
            UInt16 longit = (UInt16)(x | 0xfff);
            la = lattit * arc26;
            lo = longit * arc26;
            if ((ns | 1) > 0) la = la * -1;
            if ((ns | 2) > 0) lo = lo * -1;
        }

        /// <summary>
        /// expects 7 hex character string or N,S cordinates as csv
        /// </summary>
        /// <param name="str"></param>
        public Coordinate(string str)
        {
            if (str.Length > 5)
            {
                char[] ca = { ' ', ',' };
                string[] sarr = str.Split(ca);
                if (sarr.Length == 2)
                {
                    la = Convert.ToSingle(sarr[0]);//*arc26;
                    lo = Convert.ToSingle(sarr[1]);
                }
            }
            else if (str.Length == 5) // handles compact coordinates
            {
                string lat = str.Substring(1, 2);
                string lon = str.Substring(2, 2);
                string ns = str.Substring(0, 1);
                la = Convert.ToInt16(lat, 16);
                lo = Convert.ToInt16(lon, 16);
                byte b = Convert.ToByte(ns, 16);
                lo *= ((b & 0x01) > 0) ? -1 : 1; // == west
                la *= ((b & 0x02) > 0) ? -1 : 1;  // == south
            }
        }


        /*
        public UInt32 ToInt()
        {
        return (UInt32)((UInt32)(ns<<24)
        |(UInt32)(lattit<<12)
        |longit); 
        }   

        public float Longitude
        {
        get{
        float l = (float)Math.Round(longit / arc26,2);
        return ((ns & (byte)0x01)>0) ? l*-1 : l;
        }
            set { }
        }
        public float Latitude
        {
        get{
        float l = (float)Math.Round(lattit / arc26, 2);
        return  ((ns & (byte)0x02)>0) ? l *-1 :l;
        }
        }

        */

        public string HexName() //full hex name 12bit resolution
        {
            byte ns = (byte)((la < 0) ? 2 : 0);
            ns = (byte)((lo < 0) ? (ns | (byte)1) : ns);
            UInt16 lat = (ushort)Math.Round(Math.Abs(la) * arc26);
            UInt16 lon = (ushort)Math.Round(Math.Abs(lo) * arc26);

            return String.Format("{0:X1}{1:X3}{2:X3}", ns, lat, lon);
            //return base.ToString();
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        //5 hex characters a,b,c,d,e
        //a: 0 = ne, 1= nw, 2 = se, 3 = sw
        //bc: northings appox 70 km resolution
        //de: eastings appox 70 km resolution
        /// <summary>
        /// Name used for Region Folder
        /// </summary>
        /// <returns>region folder name</returns>
        public string CompactHexName()  //used for compact 5 char foldername in s3
        {
            byte ns = (byte)((la < 0) ? 1 : 0);  //south
            ns = (byte)((lo < 0) ? (ns | 2) : ns); //west
            UInt16 lat = (UInt16)(Math.Round(la * arc26) / 16);
            UInt16 lon = (UInt16)(Math.Round(lo * arc26) / 16);
            return String.Format("{0:X1}{1:X2}{2:X2}", ns, lat, lon);
        }
        /////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Decodes Compact region name
        /// </summary>
        /// <returns>string Region Detail</returns>

        public string DetailName()
        {
            float N = la;
            float E = lo;
            StringBuilder NS = new StringBuilder("NE");
            if (la < 0) NS[0] = 'S';
            if (lo < 0) NS[1] = 'W';
            return String.Format("{0}{1},{2}{3}",
            Math.Abs(N).ToString("F2"),
            NS[0],
            Math.Abs(E).ToString("F2"),
            NS[1]);
        }


        public string ToDisplay()
        {
            return Name + "," + DetailName() + "," + HexName();
        }

        public override string ToString()
        {
            return
                this.la.ToString("F3") + "," +
                this.lo.ToString("F3");
        }



    }
}

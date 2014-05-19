using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
   
    public class Usersettings : ICloneable
    {
        //private float _longit, _latid;
        public model.special_interest Special_Interest {get;set;}
        public model.specialty Qualification { get; set; }
        public model.work_conditions Work_Conditions { get; set; }
        //public model.coordinate Coordinates { get; set; }
        //private model.location Location;
        

        public model.Coordinate Region { get; set; }
        public string Name { get; set; }
        //public string MP_Number { get; set; }

        public Usersettings() { }

        public Usersettings(string st)
        {
            string[] sa = st.Split(',');
            Qualification = (specialty)Convert.ToByte(sa[0]);
            Work_Conditions = (work_conditions)Convert.ToByte(sa[1]);
            Region = new Coordinate(); ;//sa[3]);
            Region.Name = sa[3];
            Region.Latitude
            //Location.Name = sa[3];
            //));
            //Region = sa[3];
            Name = sa[4];
            MP_Number = sa[5];
        }

        public override string ToString()
        {
            //  short
            //  Int16 longit = (Int16)(Decimal.Round(Convert.ToDecimal(Longitude),1)*10);
            //Int16 latit = (Int16)(Decimal.Round(Convert.ToDecimal(Lattitude), 1) * 10);
            //Coordinates = (Int32)(0x00000000 | ((longit << 12) & (latit)));

           // string str = String.Format("{0},{1},{2},{3},{4},{5}",
          //  Qualification, Work_Conditions, Coordinates, Region, Name, MP_Number);
            return null;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}


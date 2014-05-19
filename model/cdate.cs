using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    public class cDate
    {
        DateTime refdate = new DateTime(2000, 1, 1);
        public int days { get; set; }

//-------------------------------------------------------------
        /// <summary>
        /// sets date == today
        /// </summary>
        public cDate()
        { TimeSpan ts = DateTime.Today - refdate; days = ts.Days; }
//---------------------------------------------------------------
        /// <summary>
        /// sets date = datetime value
        /// </summary>
        /// <param name="dt"></param>
        public cDate(DateTime dt)
        {
            TimeSpan ts = dt - refdate;
            days = ts.Days;
        }
//---------------------------------------------------------------
        /// <summary>
        /// str == number of days since 01/01/2000
        /// </summary>
        /// <param name="str"></param>
        public cDate(string str)
        {
            days = Convert.ToUInt16(str, 16);
        }

//-----------------------------------------------------------------

        /// <summary>
        /// returns days since 01/01/2000 as 4 hex digit number
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return days.ToString("X4");
            //return String.Format("{0}:X4", days); }
        }

//-------------------------------------------------------------------

        public DateTime dateTime
        {

            get { return refdate.AddDays(days); }
            set
            {
                TimeSpan ts = value - refdate;
                days = ts.Days;
            }
        }
//--------------------------------------------------------------------

    }
}


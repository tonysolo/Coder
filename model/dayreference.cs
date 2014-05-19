using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    class coderdate
    { 
        DateTime refdate = new DateTime(2000,1,1);
        public int days { get; set; }
         
      

 public  coderdate()
                {TimeSpan ts = DateTime.Today - refdate; days= ts.Days;}

  public  coderdate(DateTime dt)
                {TimeSpan ts = dt - refdate;
                  days = ts.Days;}
       
  public override string  ToString()
{
 	 return String.Format("{0}:X4", days); }
 }
    }


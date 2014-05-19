using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    class Icd
    {  public string ICD {get;set;} // between 1 and 5 codes , space separated
       public string Name {get;set;}
        public Icd() {}

        public Icd(string str)
        {
            string[] sarr = str.Split(',');
            Name = sarr[0];
            ICD = sarr[1];     
        }
        public override string ToString()
        {
            return (this!=null)? Name+' '+ICD:"";
        }
    }
}

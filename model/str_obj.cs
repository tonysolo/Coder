using System;
using System.Collections.Generic;
using System.Text;

namespace coder.model
{
    public class Str_obj
    {
        public string Str { get; set; }
        public object Ob { get; set; }
        
       public Str_obj(string str, object ob)
        { Str = str; Ob = (object)ob; }

       public Str_obj() { }
    }


}

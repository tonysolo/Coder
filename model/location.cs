using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
   public class location
    {
        public string Name { get; set; }
        public coordinate Coordinates { get; set; }


        public location(string name,string ns,string ew) //csv with 3 fields
        { 
            Name = name;
            Coordinates = new coordinate(ns,ew);
            //Coordinates = new coordinate(
        }
    }
}

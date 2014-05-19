using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    class hi_res_coordinate
    {
        public hi_res_coordinate(){}
        public string Name {get;set;}
        public string Coords { get; set; }   //northings,eastings

        public GeoRegion compact_coord
        {
            get
            {
                GeoRegion c = new Coodinate(Coords);
                c.Name = this.Name;
                return c;
            }         
        }
    }
}

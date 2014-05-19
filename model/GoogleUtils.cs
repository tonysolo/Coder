using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace coder.model
{
    static class GoogleUtils
    {

        //returns latlong -------------------------------------------------------------------------------------------------

        static public string GoogleLocationURL(string addr)
        {
            string latit = null, longit = null;
            StringBuilder sb = new StringBuilder(addr);
            sb = sb.Replace(' ', '+');
            string str = String.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", sb.ToString());
            bool okstatus = false;
            using (XmlTextReader Reader = new XmlTextReader(str))

                while (Reader.Read())
                {
                    if (Reader.NodeType == XmlNodeType.Element)

                        switch (Reader.Name)
                        {
                            case "status": Reader.Read();
                                if (Reader.Value.ToLower() == "ok") okstatus = true; break;
                            case "lat": Reader.Read(); latit = (okstatus == true) ? Reader.Value : ""; break;
                            case "lng": Reader.Read(); longit = (okstatus == true) ? Reader.Value : ""; break;
                        }
                }
            return ((latit != null) && (longit != null)) ? latit + ',' + longit : null;
        }

        //------------------------------------------------------------------------------------
        //returns url to load picturebox
        //path and / or center required
        //note fill color needs to be added
        static public string GoogleStaticMapURL(string center, string path)
        {
            string std = "&size=400x400&key=AIzaSyByqWtU4oXxdDKpkX0p6GrAFhbSojZJ_KQ&sensor=false";
            StringBuilder str = new StringBuilder("http://maps.googleapis.com/maps/api/staticmap?");

            str.Append((center != null) ? "markers=" + center : null);
            //str.Append((zoom!=null)?   );
            str.Append((path == null) ? "&zoom=12" : "&path=" + path);
            str.Append(std);
            //string str = String.Format("http://maps.googleapis.com/maps/api/staticmap?center={0}&size=400x400&key=AIzaSyByqWtU4oXxdDKpkX0p6GrAFhbSojZJ_KQ&sensor=false", coords);
            return str.ToString();
        }

        //------------------------------------------------------------------------------------


    }
}

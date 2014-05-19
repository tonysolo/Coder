using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace coder.model
{
    public class coderRegion : INotifyPropertyChanged
    {

        private string _coordinates = string.Empty;
        public event PropertyChangedEventHandler PropertyChanged;

//------------------------------------------------------------------------------

public coderRegion(string str)
{
    char[] c = new char[','];
    string[] s = str.Split(c);
    PlaceName = s[0];
    Coordinates = s[1];
}

//----------------------------------------------------------------------------

public coderRegion(string place, string coords)
{
    PlaceName = place;
    Coordinates = coords;
    HexName = new CoderRegion(coords).HexValue;
}

//------------------------------------------------------------------------------

private void NotifyPropertyChanged(String info)
{
    if (PropertyChanged != null)
    {
    PropertyChanged(this, new PropertyChangedEventArgs(info));
    }
}

//------------------------------------------------------------------------------

public string PlaceName { get; set; }

//------------------------------------------------------------------------------

public string HexName { get; set; }

//------------------------------------------------------------------------------

public string Coordinates //adapted for programatically changing this property
{
    get { return _coordinates; }
    set
    {
    _coordinates = value;
    NotifyPropertyChanged("Coordinates");
    }
}

//------------------------------------------------------------------------------

        
public override string ToString()
{
    return (PlaceName+','+Coordinates);
}
//-----------------------------------------------------------------------------
    }
}

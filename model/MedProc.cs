using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    class MedProc
    {
public string Name { get; set; }
public string[] ICDs {get;set;}
public string[] Tariffs {get;set;}

public string ICDstring 
{ 
set { ICDs = value.Split(new char[]{' ',','}); }
get { return String.Join(" ", ICDs); }
}

public string Tariffstring 
{ 
set { Tariffs = value.Split(new char[]{' ',','}); }
get { return String.Join(" ", Tariffs); }
}

public MedProc()
{ 
this.ICDs = null;
this.Tariffs = null;
this.Name = null;    
}
/// <summary>
/// Expects csv Name,ICDs,Tariffs as ssv fields
/// </summary>
/// <param name="str">Name,ICDstr,Tariffstr</param>
public MedProc(string str)//
{
string[] s = str.Split(',');
this.Name = s[0];
this.ICDs = s[1].Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
this.Tariffs = s[2].Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);   
}
/// <summary>
/// Output is the right input to the constructor
/// </summary>
/// <returns>csv string with three ssv fields</returns>
public override string  ToString()
{
return Name+','+
String.Join(" ",ICDs)+','+
String.Join(" ",Tariffs);
}

}

}

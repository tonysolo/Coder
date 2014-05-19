using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
   static class Util
    {

public static string SpaceJoin(string[] strn)
    {
    for (int i = 0; i < strn.Length; i++)
    strn[i] = strn[i].Replace(' ', '_');
    return String.Join(" ", strn);
    }

   }
}

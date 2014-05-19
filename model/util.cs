using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coder.model
{
    static class Util
    {

        public static string SpaceJoin(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
                str[i] = str[i].Replace(' ', '_');
            return String.Join(" ", str);
        }

    }
}

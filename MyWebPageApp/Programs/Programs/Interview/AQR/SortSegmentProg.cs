using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class SortSegmentProg
    {
        public string sortSegments(string s)
        {
            int i = 0;

            StringBuilder sb = new StringBuilder();


            while (i < s.Length)
            {

                if (s[i] >= '0' && s[i] <= '9')
                {
                    string tempstr = string.Empty;
                    while (i < s.Length && s[i] >= '0' && s[i] <= '9')
                    {
                        tempstr += s[i].ToString();
                        i++;

                    }

                    var res = tempstr.ToCharArray();

                    Array.Sort(res);

                    sb.Append(res);
                    continue;

                }
                else if ((s[i] >= 'A' && s[i] <= 'Z'))
                {
                    string tempstr = string.Empty;
                    while (i < s.Length && s[i] >= 'A' && s[i] <= 'Z')
                    {
                        tempstr += s[i].ToString();
                        i++;
                    }

                    var res = tempstr.ToCharArray();

                    Array.Sort(res);

                    sb.Append(res);
                   
                    continue;
                }


            }

            return sb.ToString();

        }
    }
}

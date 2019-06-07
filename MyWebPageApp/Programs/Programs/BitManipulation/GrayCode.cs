using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programs.BitManipulation
{
    public class GrayCode
    {

        public List<string> GrayCodeFunc(int n)
        {
            if (n == 0)
                return new List<string>();

            if (n == 1)
                return new List<string> { "0", "1" };

            var graycodes = GrayCodeFunc(n - 1);

            var res = new List<string>();

            for (int i = 0; i < graycodes.Count; i++)
            {
                res.Add("0" + graycodes[i]);
                res.Add("1" + graycodes[i]);
            }

            return res;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class StringManipulation
    {

        public String toUpperCase(String s)
        {
            return s.ToUpper();
        }

        public bool isUpper(String s)
        {
            foreach(char c in s.ToCharArray())
            {
                if (!char.IsUpper(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

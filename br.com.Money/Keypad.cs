using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.Money
{
    public class Keypad
    {
        // return an integer value entered by user
        public int GetInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        } // end method GetInput
    } // end class Keypad

}

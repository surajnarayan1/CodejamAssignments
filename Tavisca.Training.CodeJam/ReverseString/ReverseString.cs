using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString

    {
      

       

        
       public  void Reverse(String str)
        {
            char[] ch = str.ToCharArray();
            char[] result = str.ToCharArray();
            int i, j;
            for (i = 0, j = str.Length-1; i <str.Length; i++, j--)
            {
               result[i] = ch[j];
            }
            String ReverseString = new String(result);
            Console.WriteLine("The Reverse String is      " + ReverseString);

             

        }

       
    }
}

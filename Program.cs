using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*The problem started by 2 and increase by ...
    1)Queen stays 1 
    2)Worker increse by number of soldier and worker itself
    3)Soldier increse by number of worker then,
    ---->The soldier in current year is equal to number of worker last year and...
    ---->The worker in current year is equal to number of (worker + soldier) lastyear and +1 by queen
    >>>>>>>>Formula is >>>>>>> Queen>>1 + worker>>(w+s)+1 + Soldier>>w ; w= worker , s = soldier
    >>>>>>>> e.g. >> 
                        year 0 start with 2
                        year 1 is 1 + ((1+0)+1) + 0 = 4
                        year 2 is 1 + ((2+1)+1) +2  = 7 and 12 , 20 , 33 .......                         
    I noticed that is a "fibonacci - 1" formular. 
    */
namespace BeeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine())+4; //+4 if wanna use "Phi" function
            double ans = ((1 / Math.Sqrt(5)) * (Math.Pow(((1 + Math.Sqrt(5)) / 2), year) - Math.Pow(((1 - Math.Sqrt(5)) / 2), year))) - 1;//Following"Phi"function
/*          
 *          Another way , plase move out comments and comments the current way
 *          
 *          int q = 1;
            int w = 1;
            int s = 0;
            for (int i = 0; i<year;i++)
            {
                int temp = w; //following 1+ ((w+s)+1)+1 formular
                w = (w + s) + q;
                s = temp;
            }*/
            Console.WriteLine(ans);
            //Console.WriteLine(q+w+s);
            Console.ReadKey();
        }
    }
}

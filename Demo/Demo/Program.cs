using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int z, i = 0;
            for(int x=0;x<20;x++)
            {
                for(int y=0;y<33;y++)
                {
                    z = 100 - x - y;
                    if(5*x+3*y+z/3==100&&z%3==0)
                    {
                        Console.WriteLine("{0}、公鸡：{1}" + "\t" + "母鸡：{2}" + "\t" + "小鸡：{3}", ++i, x, y, z);
                    }
                }
                Console.ReadLine();
               
            }
        }
       
    }

}

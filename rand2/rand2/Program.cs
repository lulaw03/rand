using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();// 宣告變數
            for (int i = 0; i < 7;i++ ) 
            {
                int r0 = rand.Next(1, 43);
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);

                Console.WriteLine("{0:00}{1:00}{2:00}{3:00}{4:00}",r0,r1,r2,r3,r4);// 亂數範圍為1到43，但可能會重複
            }
            Console.ReadKey();// 停止畫面
        }
    }
}

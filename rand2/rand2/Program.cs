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
            for (int i = 0; i < 6;i++ ) 
            {
                Console.WriteLine(rand.Next(1, 43));// 亂數範圍為1到43，但可能會重複
            }
            Console.ReadKey();// 停止畫面
        }
    }
}

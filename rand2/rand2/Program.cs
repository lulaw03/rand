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
            for (int i = 0; i < 5;i++ ) 
            {
                int r0 = rand.Next(1, 43);
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);

                Console.WriteLine("{0:00}{1:00}{2:00}{3:00}{4:00}",r0,r1,r2,r3,r4);// 亂數範圍為1到43，但可能會重複
            }
          
            // 樂透機

            // 步驟一 將所有號碼放入List中
            List<int> numbers = new List<int>();
            for(int i =1 ; i <= 42 ; i++)
            {
                numbers.Add(i);
            }

            // 步驟二 隨機挑選一個數值並印出
            Random rand1 = new Random();
            for (int h = 1; h <= 6; h++ )
            {
                int r = rand.Next(1, 43);
                Console.WriteLine(numbers[r]);
            // 步湊三將其數從List屏除
                numbers.RemoveAt(r);
            }
            // 步湊四 重複六次步湊2.3.
            


            // 停止畫面
            Console.ReadKey();
        }
    }
}

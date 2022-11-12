using System;

namespace _1_4._2_循环输入数字
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                { break; }  // break跳出循环
                int n;
                if(!int.TryParse(input,out n))
                { Console.WriteLine("请重新输入数字："); continue; }  // continue的意思是回到while，进行下一次循环
                Console.WriteLine(n * 2);
            }
            Console.WriteLine("程序结束");
            Console.ReadKey();
        }
    }
}

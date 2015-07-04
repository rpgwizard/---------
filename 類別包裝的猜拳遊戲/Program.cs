using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 類別包裝的猜拳遊戲
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("剪刀=1,石頭=2,布=3,請選擇您要出的拳");
                PSS pss = new PSS(); // PSS=(paper, scissors, stone)
                pss.Userinput = Console.ReadLine();
                Console.WriteLine(pss.Getresult());
            }
        }
    }
}
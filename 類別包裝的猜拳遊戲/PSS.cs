using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 類別包裝的猜拳遊戲
{
    internal class PSS
    {
        public string Userinput;

        public string Getresult()
        {
            Random ran = new Random();
            int guess2 = ran.Next(1, 3);
            int guess1 = int.Parse(Userinput);

            if (guess1 == 1 && guess2 == 1)
            {
                return "你出剪刀，電腦出剪刀，平手!!";
            }
            if (guess1 == 2 && guess2 == 2)
            {
                return "你出石頭，電腦出石頭，平手!!";
            }
            if (guess1 == 3 && guess2 == 3)
            {
                return "你出布，電腦出布，平手!!";
            }
            if (guess1 == 1 && guess2 == 2)
            {
                return "你出剪刀，電腦出石頭，你輸了!!";
            }
            if (guess1 == 1 && guess2 == 3)
            {
                return "你出剪刀，電腦出布，你贏了!!";
            }
            if (guess1 == 2 && guess2 == 1)
            {
                return "你出石頭，電腦出剪刀，你贏了!!";
            }
            if (guess1 == 2 && guess2 == 3)
            {
                return "你出石頭，電腦出布，你輸了!!";
            }
            if (guess1 == 3 && guess2 == 2)
            {
                return "你出布，電腦出石頭，你贏了!!";
            }
            if (guess1 == 3 && guess2 == 1)
            {
                return "你出布，電腦出剪刀，你輸了!!";
            } return "就叫你輸入123了，你在那邊!!!";
        }
    }
}
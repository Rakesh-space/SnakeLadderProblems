using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblems
{
    class UC2GetNo1to6
    {
        public const int snakeKillValue = 1; //constant value to provide the snake kill
        public const int ladderValue = 5;       //constant value to provide the ladder
        public void snakeLadderUC2()
        {
            int Is_Present = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (Is_Present == empInput)
            {
                Console.WriteLine("Start the game your possition is: 0");
                int rollDiaValue = random.Next(1, 6);

                Console.WriteLine("\nyou have a get number is:" + rollDiaValue);
            }
            else
            {
                Console.WriteLine("\nplay again");
            }
        }
    }
}

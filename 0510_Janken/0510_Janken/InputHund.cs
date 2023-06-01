using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0510_Janken
{
    public class Janken_Input
    {
        public int Input()
        {
            Console.WriteLine("1～3の数字を入力してください。");
            Console.WriteLine("1:グー、2:チョキ、3:パー");
            int GetMyHund = int.Parse(Console.ReadLine());
            return GetMyHund;
        }

        public int InputJudge(int MH)
        {
            MH = (MH < 1 || MH > 3) ? Input() : MH;
            return MH;
        }
        /*
        public int Error()
        {
            return 0;
        }
        */
    }

    internal class Janken_Enemy
    {
        public int EnemyHund()
        {
            Random random = new Random();
            return (random.Next(1, 4));
        }

        public void EnemyHundMessage(int e)
        {
            switch(e)
            {
                case 1:
                    Console.WriteLine("相手：グー");
                    break;
                case 2:
                    Console.WriteLine("相手：チョキ");
                    break;
                case 3:
                    Console.WriteLine("相手：パー");
                    break;
            }
        }
    }
}

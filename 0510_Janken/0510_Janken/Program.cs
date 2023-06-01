using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0510_Janken
{
    internal class Janken
    {
        static void Main()
        {
            Janken_Input input = new Janken_Input();
            int myHand = input.Input();

            input.InputJudge(myHand);

            Janken_Enemy enemy = new Janken_Enemy();
            int enemyHund = enemy.EnemyHund();
            enemy.EnemyHundMessage(enemyHund);

            Janken_Judge judge = new Janken_Judge();
            int winOrLose = judge.Judge(myHand, enemyHund);

            switch(winOrLose)
            {
                case 1:
                    Win();
                    break;
                case 2:
                    Lose();
                    break;
                case 3:
                    Draw();
                    break;
                default:
                    Main();
                    break;
            }
        }

        static public void Win()
        {
            Console.WriteLine("あなたの勝ちです。");
        }

        static public void Lose()
        {
            Console.WriteLine("あなたの負けです。");
        }

        static public void Draw()
        {
            Console.WriteLine("あいこです。");
            Main();
        }
    }

    public class Janken_Judge
    {
        public int Judge(int m,int e)
        {
            switch (m)
            {
                case 1:
                    switch (e)
                    {
                        case 1:
                            return 3;
                        case 2:
                            return 1;
                        case 3:
                            return 2;
                        default:
                            return 4;
                    }
                case 2:
                    switch (e)
                    {
                        case 1:
                            return 2;
                        case 2:
                            return 3;
                        case 3:
                            return 1;
                        default:
                            return 4;
                    }
                case 3:
                    switch (e)
                    {
                        case 1:
                            return 1;
                        case 2:
                            return 2;
                        case 3:
                            return 3;
                        default:
                            return 4;
                    }
                default:
                    return 4;
            }
        }  
    }
}

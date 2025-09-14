using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250914_6
{
    internal class Program
    {
        //가위 바위 보 게임


        static string ChoiceToString(int choice)
        {
            switch (choice)
            {
                case 1: return "가위";
                case 2: return "바위";
                case 3: return "보";
                default: return "잘못된 입력";
            }
        }



        static void Main(string[] args)
        {
            Random rand = new Random();

            while (true)
            {
                Console.WriteLine("가위(1), 바위(2), 보(3) 중 하나를 선택하세요 (종료하려면 0 입력): ");
                int userChoice;

                // 입력이 숫자인지 확인
                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("숫자를 입력해주세요!");
                    continue;
                }

                if (userChoice == 0)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }

                if (userChoice < 1 || userChoice > 3)
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.");
                    continue;
                }

                int computerChoice = rand.Next(1, 4); // 1~3 사이 랜덤

                Console.WriteLine($"당신: {ChoiceToString(userChoice)}");
                Console.WriteLine($"컴퓨터: {ChoiceToString(computerChoice)}");

                // 승패 판정
                if (userChoice == computerChoice)
                {
                    Console.WriteLine("비겼습니다!");
                }
                else if ((userChoice == 1 && computerChoice == 3) ||
                         (userChoice == 2 && computerChoice == 1) ||
                         (userChoice == 3 && computerChoice == 2))
                {
                    Console.WriteLine("이겼습니다!");
                }
                else
                {
                    Console.WriteLine("졌습니다!");
                }


            }
        }
    }
}











using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHW18
{
    internal class Program
    {
        private static TicTacToeGame game = new TicTacToeGame();

        static void Main(string[] args)
        {
            Console.WriteLine(GetPrintableState());

            while (game.GetWinner() == Winner.GameIsUnFinished)
            {
                int index = int.Parse(Console.ReadLine());
                game.MakeMove(index-1);

                Console.WriteLine();
                Console.WriteLine(GetPrintableState());
            }

            Console.WriteLine($"Result : {game.GetWinner()}");
            Console.ReadLine();
        }

        static string GetPrintableState()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" _______________");
            sb.AppendLine("|    |     |    |");
            sb.AppendLine($"|  {GetPrintableChar(1)} |  {GetPrintableChar(2)}  |  {GetPrintableChar(3)} |");
            sb.AppendLine("|____|_____|____|");
            sb.AppendLine("|    |     |    |");
            sb.AppendLine($"|  {GetPrintableChar(4)} |  {GetPrintableChar(5)}  |  {GetPrintableChar(6)} |");
            sb.AppendLine("|____|_____|____|");
            sb.AppendLine("|    |     |    |");
            sb.AppendLine($"|  {GetPrintableChar(7)} |  {GetPrintableChar(8)}  |  {GetPrintableChar(9)} |");
            sb.AppendLine("|____|_____|____|");
            return sb.ToString();
        }

        static string GetPrintableChar(int index)
        {
            State state = game.GetState(index);
            if (state == State.Unset)
            {
                return index.ToString();
            }
            return state == State.Cross ? "X" : "O";
        }

    }
}

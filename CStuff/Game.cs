// Models/GameDo.cs
using System;

namespace Game
{
    public class GameDo
    {
        private string inputPlayer { get; set; }
        private string inputCPU { get; set; }
        private static readonly Random rnd = new Random();

        public string Play(string move)
        {
            inputPlayer = move;
            if (inputPlayer != "Rock" && inputPlayer != "Paper" && inputPlayer != "Scissors")
            {
                return "Invalid Input.";
            }
            else
            {
                CpuMove();
                return $"CPU chose: {inputCPU}\n{Winner(inputPlayer, inputCPU)}";
            }
        }

        private void CpuMove()
        {
            int randomInt = rnd.Next(1, 4);
            inputCPU = randomInt switch
            {
                1 => "Rock",
                2 => "Paper",
                3 => "Scissors",
                _ => throw new InvalidOperationException()
            };
        }

        private string Winner(string user, string AI)
        {
            if (user == AI) return "It's a Tie!";
            if ((user == "Paper" && AI == "Rock") ||
                (user == "Scissors" && AI == "Paper") ||
                (user == "Rock" && AI == "Scissors")) return "You Won!";
            return "You Lost!";
        }
    }
}

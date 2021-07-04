using System;

namespace textRPG_ver._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                game.process();
            }
        }
    }
}

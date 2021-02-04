using System;

namespace Wx4
{
    class XboxSeriesX : IConsole
    {
        public string Name => "X Box Series X";

        public string Company => "X Box";

        public string RunGame(Game game)
        {
            if (game.Path != Constants.Midias.cd)
            {
                throw new Exception("Não roda jogos online, apenas CDS!");
            }

            return "Your Xbox Series X (made for poor people like you.";
        }
    }
}

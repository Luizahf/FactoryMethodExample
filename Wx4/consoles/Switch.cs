

using System;

namespace Wx4
{
    class Switch
    {
        public string Name => "Switch";

        public string Company => "Nintendo";

        public string RunGame(Game game)
        {
            if (game.Path != Constants.Midias.cd)
            {
                throw new Exception("Não roda jogos online, apenas CDS!");
            }

            return "Your Switch (made for anyone with enough money to spend on this shit) is running the game X";
        }
    }
}

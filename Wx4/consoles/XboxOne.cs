namespace Wx4
{
    class XboxOne : IConsole
    {
        public string Name => "XBox One X";

        public string Company => "X Box";

        public string RunGame(Game game)
        {
            return "Your Xbox One X (made for rich people like you is running the game X";
        }
    }
}

namespace Wx4
{
    class PS5 : IConsole
    {
        public string Name => "PS5";

        public string Company => "PS";

        public string RunGame(Game game)
        {
            return "Your PS5 (made for fucking idiots like you because I'm a sucky console) is running the game X";
        }
    }
}

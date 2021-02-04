namespace Wx4
{
    interface IConsole
    {
        string Name { get; }
        string Company { get; }
        string RunGame(Game game);
    }
}

namespace Wx4
{
    class Game
    {
        public string Name { get; private set; }
        public string Path { get; private set; }
        public Game(string name, string path)
        {
            Name = name;
            Path = path;
        }
    }
}

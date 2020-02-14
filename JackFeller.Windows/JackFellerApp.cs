using Xenko.Engine;

namespace JackFeller.Windows
{
    class JackFellerApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}

using gameStore.Models;

namespace gameStore;

public class GameClient
{
    private static readonly List<Game> games = new(){
        new Game(){
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateTime(1991,2,1)
        },
         new Game(){
            Id = 2,
            Name = "Fifa Street iiII",
            Genre = "Esports",
            Price = 59.95M,
            ReleaseDate = new DateTime(1991,2,1)
        },
        new Game(){
            Id = 1,
            Name = "Final Fantasy",
            Genre = "Role Playng",
            Price = 69.97M,
            ReleaseDate = new DateTime(1991,2,1)
        },

};

    public static Game[] GetGames()
    {
        Console.WriteLine($"Number of games in the list: {games.Count}");
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        games.Add(game);
    }
}
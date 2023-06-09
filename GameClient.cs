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
            Name = "Fifa Street II",
            Genre = "Esports",
            Price = 59.95M,
            ReleaseDate = new DateTime(1991,2,1)
        },
        new Game(){
            Id = 3,
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
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("could not find game");
    }

    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;

    }

    public static void DeleteGame(int id) 
    {
        Game game = GetGame(id);
        games.Remove(game);
    }
}
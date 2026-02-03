using Slasher.GameConsole.Visualizers;
using Slasher.GameLibrary;

namespace Slasher.GameConsole;

internal class Program
{
    static GameMap gameMap;
    static void Main(string[] args)
    {
        gameMap = new GameMap(8, 8);
        DrawMap(gameMap);
    }

    private static void DrawMap(GameMap mapToDraw)
    {
        Console.Clear();
        for (int x = 0; x < mapToDraw.Tiles.GetLength(0); x++)
        {
            for (int y = 0; y < mapToDraw.Tiles.GetLength(1); y++)
            {
                DrawTile(x, y);
            }

        }
    }

    private static void DrawTile(int x, int y)
    {
        var tileType = gameMap.Tiles[x, y];
        char displayCharacter = TileTypeToCharacterMap.Dictionary[tileType];

        Console.SetCursorPosition(x*2, y);
        Console.Write(displayCharacter);
    }
}

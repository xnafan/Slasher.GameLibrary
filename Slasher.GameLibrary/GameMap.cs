
namespace Slasher.GameLibrary
{
    public class GameMap
    {
        public TileType[,] Tiles { get; set; }

        public GameMap(int width, int height)
        {
            Tiles = new TileType[width, height];
            GenerateRandomMap();
        }

        private void GenerateRandomMap()
        {
            var possibleValues = Enum.GetValues<TileType>();

            for (int x = 0; x < Tiles.GetLength(0); x++)
            {
                for (int y = 0; y < Tiles.GetLength(1); y++)
                {

                    var randomInt = Random.Shared.Next(possibleValues.Count());

                    Tiles[x, y] = possibleValues[randomInt];

                }
            }
        }
    }
}

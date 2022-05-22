using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] int _height;
    [SerializeField] int _width;

    [SerializeField] private Tile tilePrefab;

    [SerializeField] Transform _mainCameraTransform;

    public Dictionary<Vector2, Tile> tiles; //only public for MovementLibrary


    private void Start()
    {
        GenerateGrid();
    }
    void GenerateGrid()
    {
        tiles = new Dictionary<Vector2, Tile>();
        Vector2 _positionVector = new Vector2();
        for (int x = 0; x < _width; x++)
        {
            _positionVector.x = x; //Set X
            for (int y = 0; y < _height; y++)
            {
                Tile spawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"GridTile {x} {y}";
                _positionVector.y = y; //Set Y
                spawnedTile.Position = _positionVector; //position assigned to each Tile

                tiles[new Vector2(x, y)] = spawnedTile;
            }
        }
        

        _mainCameraTransform.position = new Vector3(_width / 2, _height / 2, -10);
    }



    public Tile getTileAtPosition(Vector2 position)
    {
        if(tiles.TryGetValue(position,out Tile tile))
        {
            return tile;
        }
        return null;
    }
}

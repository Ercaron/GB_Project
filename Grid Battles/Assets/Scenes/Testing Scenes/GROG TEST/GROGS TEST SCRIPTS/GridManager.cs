using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] int _height;
    [SerializeField] int _width;

    [SerializeField] private GridTile _gridTilePrefab;

    [SerializeField] Transform _mainCameraTransform;

    private Dictionary<Vector2, GridTile> _tiles;
    private void Start()
    {
        GenerateGrid();
    }
    void GenerateGrid()
    {
        _tiles = new Dictionary<Vector2, GridTile>();
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                GridTile spawnedTile = Instantiate(_gridTilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"GridTile {x} {y}";

                _tiles[new Vector2(x, y)] = spawnedTile;
            }
        }

        _mainCameraTransform.position = new Vector3(_width / 2, _height / 2, -10);
    }

    public GridTile getTileAtPosition(Vector2 position)
    {
        if(_tiles.TryGetValue(position,out GridTile tile))
        {
            return tile;
        }
        return null;
    }
}

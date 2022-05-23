using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    Unit _unit;
    Vector2 _position;


    public Unit Unit { get => _unit; set => _unit = value; }
    public Vector2 Position { get => _position; set => _position = value; }

}

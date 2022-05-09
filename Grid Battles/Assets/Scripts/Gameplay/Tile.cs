using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    Unit _unit;
    //Adjacent Tiles? 


    public Unit Unit { get => _unit; set => _unit = value; }


    //TEMPORAL HASTA TENER BORDES
    Renderer _renderer;



    private void Start()
    {
        _renderer = GetComponent<Renderer>();

        _renderer.material.SetColor("_Color", new Vector4(RandNum(), RandNum(), RandNum(), RandNum()));
    }

    float RandNum()
    {
        return Random.Range(0, 1f);
    }
}

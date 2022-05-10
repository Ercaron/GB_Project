using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    int _hp;
    int _maxHP;
    


    Tile _currentTile;
    SpriteRenderer _spRenderer;

    UnitData _unitData;

    public UnitData UnitData { get => _unitData; set { _unitData = value; Debug.Log("data set"); SetData(); } }



    void OnEnable()
    {
        _spRenderer = GetComponent<SpriteRenderer>();
        
    }


    void SetData()
    {
        //InstantiateParticles
        _spRenderer.sprite = _unitData.Sprite;
    }
}

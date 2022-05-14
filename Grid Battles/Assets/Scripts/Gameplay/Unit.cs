using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    int _hp;
    int _maxHP;
    


    Tile _currentTile;
    SpriteRenderer _spRenderer;

    [SerializeField] UnitData _unitData;

    

    public UnitData UnitData { get => _unitData; set { _unitData = value; SetData(); } }



    void OnEnable()
    {
        _spRenderer = GetComponent<SpriteRenderer>();

        if (gameObject.layer == 8)//Enemy layer
            _spRenderer.material.color = Color.red;

        if (_unitData)
        {
            SetData();
        }

    }


    void SetData()
    {
        //InstantiateParticles
        _spRenderer.sprite = _unitData.Sprite;
    }

    public virtual void Action()
    {

    }
}

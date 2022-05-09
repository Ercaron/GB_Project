using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    UIManager _uiManager;


    [SerializeField] GameObject _unitPrefab;


    [SerializeField] int _coins;
    [SerializeField] List<UnitData> _mapUnits;

    private void OnEnable()
    {
        
    }

    void Start()
    {
        _uiManager = GetComponent<UIManager>();
        _uiManager.SetMapUnits(_mapUnits);
        _uiManager.UpdateCoins(_coins);
    }

    
    void Update()
    {
        
    }


    public void StartBattle()
    {

    }


    public void CreateUnit(UnitData data, Tile tile)
    {
        Unit newUnit = Instantiate(_unitPrefab).GetComponent<Unit>();
        newUnit.UnitData = data;
        tile.Unit = newUnit;


    }
}

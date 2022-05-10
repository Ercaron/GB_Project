using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    UIManager _uiManager;


    UnitPlacer _placer;


    [SerializeField] int _coins;
    [SerializeField] List<UnitData> _mapUnits;


    void Start()
    {
        _placer = GetComponent<UnitPlacer>();
        _placer.UnitPlaced += UnitPlaced;

        _uiManager = GetComponent<UIManager>();
        _uiManager.SetMapUnits(_mapUnits);
        _uiManager.UpdateCoins(_coins);
    }

    

    public void StartBattle()
    {

    }


    void UnitPlaced(UnitData data)
    {
        _coins -= data.Cost;
        _uiManager.UpdateCoins(_coins);
    }

    
}

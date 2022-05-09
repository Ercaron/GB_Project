using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    GameManager _gManager;


    //UI Play

    [SerializeField] UnitSelector _unitSelector;
    [SerializeField] TextMeshProUGUI _coinsText;

    void Start()
    {
        _gManager = GetComponent<GameManager>();
        
        //Suscribe to Start battle from UI button
    }

    
    public void SetMapUnits(List<UnitData> units)
    {
        _unitSelector.SetUnits(units);
    }

    public void UpdateCoins(int coins)
    {
        _coinsText.text = coins.ToString();

        _unitSelector.UpdateAvailableUnits(coins);
    }
}

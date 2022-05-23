using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    //UI Play
    [SerializeField] UnitSelector _unitSelector;
    [SerializeField] TextMeshProUGUI _coinsText;


    private void Awake()
    {
        instance = this;
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

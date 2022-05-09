using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UnitSelector : MonoBehaviour
{

    [SerializeField] GameObject _unitsParent;
    [SerializeField] GameObject _unitUIprefab;

    List<UnitData> _units;

    Dictionary<UnitData, GameObject> _dicDataToUnits = new Dictionary<UnitData, GameObject>();
    


    public void SetUnits(List<UnitData> units)
    {
        foreach (var unit in units)
        {
            var unitObject = Instantiate(_unitUIprefab, _unitsParent.transform);
            var texts = unitObject.GetComponentsInChildren<TextMeshProUGUI>();
            texts[0].text = unit.Name;
            texts[1].text = unit.Cost.ToString();
            unitObject.GetComponentInChildren<Image>().sprite = unit.Sprite;

            unitObject.GetComponentInChildren<Button>().onClick.AddListener(delegate { SelectUnit(unit); });


            _dicDataToUnits.Add(unit, unitObject);
        }
    }


    public void SelectUnit(UnitData data) //add buttibn to set states 
    {

    }

    public void UpdateAvailableUnits(int availableCoins)
    {
        foreach (var unit in _dicDataToUnits)
        {
            if(unit.Key.Cost > availableCoins)
            {
                unit.Value.GetComponentInChildren<Button>().interactable = false;

            }
            else
            {
                unit.Value.GetComponentInChildren<Button>().interactable = true;
            }
        }
    }
}

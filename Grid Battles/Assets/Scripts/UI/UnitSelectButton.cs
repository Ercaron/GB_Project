using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UnitSelectButton : Button
{
    public UnitData UnitData;
    public delegate void OnDeselection(UnitData data);
    public event OnDeselection OnButtonDeselect;

    public override void OnDeselect(BaseEventData eventData)
    {
        base.OnDeselect(eventData);

        OnButtonDeselect(UnitData);
    }
}

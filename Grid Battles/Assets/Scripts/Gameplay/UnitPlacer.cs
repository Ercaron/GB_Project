using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitPlacer : MonoBehaviour
{
    public UnitData SelectedUnit;
    bool _clickBlock;


    public delegate void OnUnitPlaced(UnitData data);
    public event OnUnitPlaced UnitPlaced;

    
    void Update()
    {
        if(Input.GetMouseButtonUp(0) && _clickBlock == false) //Check clickblock only if click in button.
        {
            _clickBlock = true;
        }
        else if(Input.GetMouseButtonUp(0) && _clickBlock == true)
        {

            if (SelectedUnit)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if(Physics.Raycast(ray,out hit,200))
                {
                    Debug.Log("Le pegue a " + hit.collider.name , hit.collider);


                   Tile tile = hit.collider.GetComponent<Tile>();

                    if (!tile.Unit)
                    {
                        CreateUnit(SelectedUnit, tile);
                        //position of unit

                    }
                    else
                    {
                        Debug.Log("This Tile is already Occupied"); //Convert To Feedback
                    }
                }

                SelectedUnit = null;
                _clickBlock = false;
            }
            else
            {
                Debug.Log("No unit selected"); //Convert To Feedback
            }
        }
       
    }

    public void CreateUnit(UnitData data, Tile tile)
    {
        Unit newUnit = Instantiate(data.Prefab).GetComponent<Unit>();
        newUnit.UnitData = data;
        tile.Unit = newUnit;
        newUnit.transform.position = tile.transform.position + new Vector3(0, 1, 0);//Ponerlo en el medio, either poner un gameobject vacio en la posicion o hacer calculo de width y height


        UnitPlaced(data);

    }
}

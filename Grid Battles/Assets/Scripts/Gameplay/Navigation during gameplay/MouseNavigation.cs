using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseNavigation : MonoBehaviour
{
    [SerializeField] float dragSensibility;
    bool _isDragging;

    Vector3 _currentMousePosition;
    Vector3 _nextMousePosition;

    private void Awake()
    {
        _currentMousePosition = new Vector3(0, 0, 0);
        _nextMousePosition = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        Drag(IsItDragging());
    }

    private bool IsItDragging()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Tiles") && !EventSystem.current.IsPointerOverGameObject())
                {
                    Debug.Log("OKKKKKKKKKKK");
                    _currentMousePosition = Input.mousePosition;
                    _isDragging = true;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _isDragging = false;
        }
        return _isDragging;
    }
    private void Drag(bool IsDragging)
    {
        if(IsDragging)
        {
            Vector3 cameraMoveVector;
            Debug.Log(_currentMousePosition);
            Debug.Log(_nextMousePosition);
            Debug.Log("Drag difference: " + (_currentMousePosition - _nextMousePosition));


            _nextMousePosition = Input.mousePosition;
            cameraMoveVector = new Vector3(_currentMousePosition.x - _nextMousePosition.x, 0, _currentMousePosition.y - _nextMousePosition.y);
            Camera.main.transform.position += (cameraMoveVector / 100) * dragSensibility;
            _currentMousePosition = _nextMousePosition;
        }
    }
}

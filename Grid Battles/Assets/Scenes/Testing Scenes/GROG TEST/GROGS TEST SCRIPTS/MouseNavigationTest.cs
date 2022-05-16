using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseNavigationTest : MonoBehaviour
{
    [SerializeField] float _dragSensibility;
    bool _isDragging;

    Vector3 _currentMousePosition;
    Vector3 _nextMousePosition;

    [SerializeField] float _maxZoomSensibility;
    float _zoomSensibility;

    private void Awake()
    {
        _currentMousePosition = new Vector3(0, 0, 0);
        _nextMousePosition = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        if (IsItDragging())
        {
            Drag();
        }
        else if (IsItZooming())
        {
            _zoomSensibility = 0.1f * Camera.main.transform.position.z;
            if (Input.mouseScrollDelta.y == 1)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private bool IsItDragging()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("input");
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
    private bool IsItZooming()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            return true;
        }
        return false;
    }
    private void Drag()
    {
        Vector3 cameraMoveVector;
        Debug.Log(_currentMousePosition);
        Debug.Log(_nextMousePosition);
        //Debug.Log("Drag difference: " + (_currentMousePosition - _nextMousePosition));


        _nextMousePosition = Input.mousePosition;
        cameraMoveVector = new Vector3(_currentMousePosition.x - _nextMousePosition.x, _currentMousePosition.y - _nextMousePosition.y, 0);
        Camera.main.transform.position += (cameraMoveVector / 100) * _dragSensibility;
        _currentMousePosition = _nextMousePosition;
    }

    private void ZoomIn()
    {
        Camera.main.transform.position += new Vector3(0,0, -_maxZoomSensibility * _zoomSensibility);
    }
    private void ZoomOut()
    {
        Camera.main.transform.position += new Vector3(0,0, _maxZoomSensibility * _zoomSensibility);
    }
}

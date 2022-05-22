using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLibrary : MonoBehaviour
{
    [SerializeField] GridManager gridManager;

    public static MovementLibrary movementLibrary;

    private void Awake()
    {
        if(movementLibrary != null)
        {
            GameObject.Destroy(movementLibrary);
        }
        else
        {
            movementLibrary = this;
        }
    }
    //------------------- Public Functions
    public bool IsAdjacent(Vector2 myPosition, Vector2 questionedPosition)
    {
        if(myPosition.x == questionedPosition.x)
        {
            if(myPosition.y == questionedPosition.y + 1 || myPosition.y == questionedPosition.y - 1)
            {
                return true;
            }
        }
        else if(myPosition.y == questionedPosition.y)
        {
            if (myPosition.x == questionedPosition.x + 1 || myPosition.x == questionedPosition.x - 1)
            {
                return true;
            }
        }
        return false;
    }

    public void TryMoveUp(Vector2 currentPosition)
    {

    }

    //------------------- Private Functions
    private void MoveUp(Vector2 currentPosition)
    {
        currentPosition.y += 1;
    }
    private void MoveDown(Vector2 currentPosition)
    {
        currentPosition.y -= 1;
    }
    private void MoveLeft(Vector2 currentPosition)
    {
        currentPosition.x -= 1;
    }
    private void MoveRight(Vector2 currentPosition)
    {
        currentPosition.x += 1;
    }

}

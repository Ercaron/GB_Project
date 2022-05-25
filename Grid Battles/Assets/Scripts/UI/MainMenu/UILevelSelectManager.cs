using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelSelectManager : MonoBehaviour
{
    [SerializeField] List<LevelButtons> _levelButtons;
    [SerializeField] int _maxSheets;
    public int currentLevelSheet;

    private void Awake()
    {
        currentLevelSheet = 0;
    }

    public void NextSheet()
    {
        currentLevelSheet += 1;
        if (currentLevelSheet > _maxSheets-1)
        {
            currentLevelSheet -= 1;
            Debug.LogError("NO MORE SHEETS AVAILABLE");
            return;
        }
        int aux2 = currentLevelSheet * _levelButtons.Count;
        for (int i = 0; i < _levelButtons.Count; i++)
        {
            _levelButtons[i].UpdateLevelDisplayed(i+aux2);
        }
    }
    public void PreviousSheet()
    {
        currentLevelSheet -= 1;
        if (currentLevelSheet < 0)
        {
            currentLevelSheet += 1;
            Debug.LogError("THERE ARE NO NEGATIVE LEVELS");
            return;
        }
        int aux2 = currentLevelSheet * _levelButtons.Count;
        for (int i = 0; i < _levelButtons.Count; i++)
        {
            _levelButtons[i].UpdateLevelDisplayed(i + aux2);
        }
    }
    

}

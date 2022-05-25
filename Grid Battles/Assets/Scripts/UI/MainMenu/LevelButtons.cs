using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelButtons : MonoBehaviour
{
    [SerializeField] AudioClip _clickedAudioClip;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] TMP_Text _myText;

    public int currentLevelDisplayed;

    public void OnButtonClick()
    {
        _audioSource.PlayOneShot(_clickedAudioClip);
        //Logica para generarGrilla + pasar a estado batalla etc basado en currentLevelDisplayed
    }

    public void UpdateLevelDisplayed(int level)
    {
        _myText.text = level.ToString();
        currentLevelDisplayed = level;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectButton : MonoBehaviour
{
    [SerializeField] AudioClip _clickedAudioClip;
    [SerializeField] AudioSource _audioSource;

    [SerializeField] GameObject _levelSelectGO;
    [SerializeField] GameObject _mainScreenGO;

    public void OnButtonClick()
    {
        _audioSource.PlayOneShot(_clickedAudioClip);
        _levelSelectGO.SetActive(true);
        _mainScreenGO.SetActive(false);
        Debug.Log("Clicked LevelSelect Button");
    }
}

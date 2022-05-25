using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToMainScreenButton : MonoBehaviour
{
    [SerializeField] AudioClip _clickedAudioClip;
    [SerializeField] AudioSource _audioSource;

    [SerializeField] GameObject _levelSelectGO;
    [SerializeField] GameObject _mainScreenGO;

    public void OnButtonClick()
    {
        _audioSource.PlayOneShot(_clickedAudioClip);
        _levelSelectGO.SetActive(false);
        _mainScreenGO.SetActive(true);
        Debug.Log("Clicked LevelSelect Button");
    }
}

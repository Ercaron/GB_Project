using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] AudioClip _clickedAudioClip;
    [SerializeField] AudioSource _audioSource;

    public void OnButtonClick()
    {
        _audioSource.PlayOneShot(_clickedAudioClip);
        Debug.Log("Clicked Exit Button");
        Application.Quit();
    }
}

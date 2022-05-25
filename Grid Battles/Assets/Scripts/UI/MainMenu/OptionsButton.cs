using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    [SerializeField] AudioClip _clickedAudioClip;
    [SerializeField] AudioSource _audioSource;

    public void OnButtonClick()
    {
        _audioSource.PlayOneShot(_clickedAudioClip);
        Debug.Log("Clicked Options Button");
    }
}

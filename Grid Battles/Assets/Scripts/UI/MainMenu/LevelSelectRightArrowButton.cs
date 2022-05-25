using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectRightArrowButton : MonoBehaviour
{
    [SerializeField] AudioClip _clickedAudioClip;
    [SerializeField] AudioSource _audioSource;

    [SerializeField] UILevelSelectManager _levelSelectManagerReference;

    public void OnButtonClick()
    {
        _audioSource.PlayOneShot(_clickedAudioClip);
        _levelSelectManagerReference.NextSheet();
    }
}

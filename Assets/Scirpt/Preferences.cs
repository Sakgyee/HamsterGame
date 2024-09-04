using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preferences : MonoBehaviour
{
    public GameObject PreferencesCanvas;

    public AudioSource audioSource;

    public void IntoPreferences()
    {       
        PreferencesCanvas.SetActive(true);
        audioSource.Play();
    }
    public void Backtomain()
    {
        PreferencesCanvas.SetActive(false);
        audioSource.Play();
    }
}

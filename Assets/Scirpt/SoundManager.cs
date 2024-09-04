using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioMixer masterMixter;
    public Slider BGMSlider;
    public Slider SFXSlider;
    public void AudioControl()
    {
        float bgm = BGMSlider.value;

        if (bgm == -40f)
        {
            masterMixter.SetFloat("BGM", -80f);
        }
        else
        {
            masterMixter.SetFloat("BGM", bgm);
        }
        float sfx = SFXSlider.value;

        if (sfx == -40f)
        {
            masterMixter.SetFloat("SFX", -80f);
        }
        else
        {
            masterMixter.SetFloat("SFX", sfx);
        }

    }

    public void ToggleAudioVolume()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
}

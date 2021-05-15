using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SliderSource : MonoBehaviour {

    public AudioMixer mix;

    public void SetMusicLevel(float sliderValue)
    {
        mix.SetFloat("VolumeMusic", Mathf.Log10(sliderValue) * 20);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundOptionsScript : MonoBehaviour
{
    [SerializeField] AudioMixer am;
    [SerializeField] Slider masterSlider;

    void SetVolume(string name, Slider slider){
        //float volume = Mathf.Log10(slider.value) * 20;
        //if(slider.value == 0){
        //    volume = -80;
        //}
        am.SetFloat(name, slider.value);
        //PlayerPrefs
    }

    public void SetMasterVolume(){
        SetVolume("Master", masterSlider);
    }
}

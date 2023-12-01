using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundOptionsScript : MonoBehaviour
{
    [SerializeField] AudioMixer am;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    void Start(){
        if(PlayerPrefs.GetInt("Default Volume Changed") == 0){
            masterSlider.value = 0.15f;
            musicSlider.value = 0.15f;
            sfxSlider.value = 0.15f;
            PlayerPrefs.SetInt("Default Volume Changed",1);
        }
        masterSlider.value = PlayerPrefs.GetFloat("Master");
        musicSlider.value = PlayerPrefs.GetFloat("Music");
        sfxSlider.value = PlayerPrefs.GetFloat("sfx");
    }

    void SetVolume(string name, Slider slider){
        PlayerPrefs.SetFloat(name, slider.value);

        float volume = Mathf.Log10(slider.value) * 20;
        if(slider.value == 0){
            volume = -80;
        }
        am.SetFloat(name, volume);
        PlayerPrefs.SetFloat(name, slider.value);
    }

    public void SetMasterVolume(){
        SetVolume("Master", masterSlider);
    }

    public void SetMusicVolume(){
        SetVolume("Music", musicSlider);
    }

    public void SetSFXVolume(){
        SetVolume("sfx", sfxSlider);
    }
}

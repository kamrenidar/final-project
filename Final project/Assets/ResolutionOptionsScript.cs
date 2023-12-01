using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResolutionOptionsScript : MonoBehaviour
{
    [SerializeField] Dropdown resolutionDD;
    [SerializeField] Toggle toggle;

    Resolution[] resolutions;
    

    void Start(){
        resolutions = Screen.resolutions;
        toggle.isOn = PlayerPrefs.GetInt("fullscreen") == 0;

        bool setDefault = false;
        if(PlayerPrefs.GetInt("set default resolution") == 0){
            setDefault = true;
            PlayerPrefs.SetInt("set default resolution", 1);
        }

        for(int i = 0; i < resolutions.Length; i++){
            string resolutionString = resolutions[i].width.ToString() + " x " + resolutions[i].height.ToString();
            resolutionDD.options.Add(new Dropdown.OptionData(resolutionString));
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                resolutionDD.value = i;
            }
        }
        resolutionDD.value = PlayerPrefs.GetInt("Resolution Selection");
        
    }
    
    public void ChangeResolution(){
        Screen.SetResolution(resolutions[resolutionDD.value].width, resolutions[resolutionDD.value].height, toggle.isOn);
        PlayerPrefs.SetInt("Resolution Selection", resolutionDD.value);
        if(toggle.isOn) PlayerPrefs.SetInt("fullscreen",0);
        else PlayerPrefs.SetInt("fullscreen",1);
        
    }
}

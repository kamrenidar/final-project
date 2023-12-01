using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class sceneTransitionHandler : MonoBehaviour
{
    [SerializeField] AudioMixer am;
    [SerializeField] string name;
    
    public float fadeTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void sceneTransition(string scene){
        StartCoroutine(FadeAudio(scene));
    }

    IEnumerator FadeAudio(string scene)
    {
        float time = 0.0f;
        while(time < fadeTime){
            time += Time.deltaTime;

            float volume = Mathf.Lerp(0f, -80f, time / fadeTime);

            am.SetFloat(name, volume);

            yield return null;
        }
        am.SetFloat(name, -80f);

        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene(scene);
    }
}

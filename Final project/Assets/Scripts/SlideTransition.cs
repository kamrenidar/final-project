using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideTransition : MonoBehaviour
{
    [SerializeField] Image slideImage;
    [SerializeField] float slideTime = 1f;
    [SerializeField] int sceneType;

    void Awake(){
        if(sceneType == 1){
            Slide();
        }
    }

    public void Slide(){

        StartCoroutine(SlideRoutine());
        

        IEnumerator SlideRoutine(){
            float timer = 0f;
            RectTransform image = slideImage.GetComponent<RectTransform>();
            float oldX = image.anchoredPosition.x;
            while(timer < slideTime){
                timer+=Time.deltaTime;
                image.anchoredPosition = new Vector2(oldX - (1150 * timer/slideTime), image.anchoredPosition.y);
                yield return null;
            }
            yield return null;
        }

    }
}

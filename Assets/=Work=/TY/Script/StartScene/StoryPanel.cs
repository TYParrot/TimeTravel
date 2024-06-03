using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPanel : MonoBehaviour
{
    private GameObject[] imgs;
    public GameObject mascot;

    IEnumerator StoryImg(){

        foreach (GameObject img in imgs){
            img.SetActive(true);

            yield return new WaitForSeconds(5.0f);
            img.SetActive(false);
        }
        gameObject.SetActive(false);
        mascot.SetActive(true);
    }

    public void Setting(){
        imgs = new GameObject[gameObject.transform.childCount];
        for(int i = 0; i<gameObject.transform.childCount; i++){
            imgs[i] = gameObject.transform.GetChild(i).gameObject;
        }
        mascot.SetActive(false);
        StartCoroutine(StoryImg());
    }
}

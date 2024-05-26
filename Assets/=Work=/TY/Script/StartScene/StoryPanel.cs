using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPanel : MonoBehaviour
{
    private GameObject[] imgs;
    // Start is called before the first frame update
    void Start()
    {
        imgs = new GameObject[gameObject.transform.childCount];
        for(int i = 0; i<gameObject.transform.childCount; i++){
            imgs[i] = gameObject.transform.GetChild(i).gameObject;
        }

        StartCoroutine(StoryImg());
    }

    IEnumerator StoryImg(){

        foreach (GameObject img in imgs){
            img.SetActive(true);

            yield return new WaitForSeconds(4.0f);
            img.SetActive(false);
        }
    }
}

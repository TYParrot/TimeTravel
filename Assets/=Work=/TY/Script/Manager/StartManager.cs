using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public void Start(){
        Managers.Game.SceneSetting();
    }

    private void StartBtn(){
        Managers.Game.changeScene(5);
    }

    public void ExitBtn(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    #region ShowStory
    public GameObject storyPanel;
    private GameObject[] imgs;
    public GameObject mascot;

    IEnumerator StoryImg(){

        foreach (GameObject img in imgs){
            img.SetActive(true);

            yield return new WaitForSeconds(8.0f);
            img.SetActive(false);
        }
        storyPanel.SetActive(false);
        mascot.SetActive(true);
        StartBtn();
    }

    public void Setting(){
        imgs = new GameObject[storyPanel.transform.childCount];
        for(int i = 0; i<storyPanel.transform.childCount; i++){
            imgs[i] = storyPanel.transform.GetChild(i).gameObject;
        }
        mascot.SetActive(false);
        StartCoroutine(StoryImg());
    }
    #endregion
}

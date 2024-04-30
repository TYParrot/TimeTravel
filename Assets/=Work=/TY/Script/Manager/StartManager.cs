using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public GameObject CreditPanel;

    public void Start(){
        Managers.Game.SceneSetting();
    }

    public void StartBtn(){
        Managers.Game.changeScene(1);
    }

    public void CreditBtn(){
        CreditPanel.SetActive(true);
    }

    public void ExitBtn(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public GameObject CreditPanel;

    public void StartBtn(){
        //1번은 House 씬
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

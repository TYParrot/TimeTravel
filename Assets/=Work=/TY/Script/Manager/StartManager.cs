using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public void Start(){
        Managers.Game.SceneSetting();
    }

    public void StartBtn(){
        Managers.Game.changeScene(5);
    }

    public void ExitBtn(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

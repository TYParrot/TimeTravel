using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//게임의 Pause 및 Resume 기능, 초기 화면으로 돌아가는 버튼
//처음 Start 화면으로 돌아가는 버튼 기능은 HomePanel 아래에 있는 수락 버튼에 구현.
//Start 화면으로 돌아가겠느냐에 대한 재확인은 HomePanel 활성화
public class PauseManager : MonoBehaviour
{
    public static bool isPause = false;
    public GameObject CheckPanel;

    public void Start(){
        if(CheckPanel == null){
            CheckPanel = GameObject.Find("CheckPanel");
        }
    }

    public void Pause(){
        Time.timeScale = 0f;
        isPause = true;
    }

    public void Resume(){
        Time.timeScale = 1.0f;
        isPause = false;
    }

    public void Cancel(){
        CheckPanel.SetActive(false);
    }

    public void GoHome(){
        Managers.Game.changeScene(0);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GoStartSceneBtn : MonoBehaviour
{
    //사용자가 돌아가기 버튼을 누르지 않아도, 버튼이 active된 시점부터 10초가 지나면 자동으로 씬 전환
    void OnEnable(){
        StartCoroutine(AutoChangeStartScene());
    }

    public void GoStartScene(){
        Managers.Game.changeScene(0);
    }

    IEnumerator AutoChangeStartScene()
    {
        yield return new WaitForSeconds(20.0f); 
        Managers.Game.changeScene(0);
    }
}

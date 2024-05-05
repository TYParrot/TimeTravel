using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//각 미니게임에 대한 전환을 테스트해보는 스크립트입니다.
public class GoToGameScene : MonoBehaviour
{
    public void GoToRadioGame(){
        Managers.Game.changeScene(2);
    }

    public void RadioToHouse(){
        Managers.Game.ClearRadio(true);
        Managers.Game.changeScene(1);
    }

    public void AllClear(){
        Managers.Game.ClearMicrowave(true);
        Managers.Game.ClearRadio(true);
        Managers.Game.ClearTelephone(true);
        Managers.Game.changeScene(1);
    }
}

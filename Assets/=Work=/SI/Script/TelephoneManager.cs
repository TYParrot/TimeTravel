using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneManager : MonoBehaviour
{
    void Start()
    {
        Managers.Game.SceneSetting();
    }

    public void ClearGame()
    {
        Managers.Game.ClearTelephone(true);
        Managers.Game.changeScene(1);
    }

}

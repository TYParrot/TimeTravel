using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MicrowaveManager : MonoBehaviour
{
    void Start()
    {
        Managers.Game.SceneSetting();
    }

  
    public void ClearGame(){
        Managers.Game.ClearMicrowave(true);
        Managers.Game.changeScene(1);
    }



}

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
    Managers.Game.ClearMicroWave();
    Managers.Game.changeScene(1);
   }
}

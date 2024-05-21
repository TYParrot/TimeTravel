using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSetting : MonoBehaviour
{
    public GameObject TextCanvas;

    // Start is called before the first frame update
    void Start()
    {
        if(Managers.Game.ReturnRadio()){
            TextCanvas.SetActive(false);
        }
    }

    public void GoToRadio(){
        if(!Managers.Game.ReturnRadio()){
            Managers.Game.changeScene(2);
        }
        
    }
}

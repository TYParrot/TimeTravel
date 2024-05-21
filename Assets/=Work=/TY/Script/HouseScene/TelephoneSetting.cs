using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneSetting : MonoBehaviour
{
    public GameObject TextCanvas;

    // Start is called before the first frame update
    void Start()
    {
        if(Managers.Game.ReturnTelephone()){
            TextCanvas.SetActive(false);
        }
    }
}

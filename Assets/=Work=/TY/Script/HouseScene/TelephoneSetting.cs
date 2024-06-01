using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TelephoneSetting : MonoBehaviour
{
    public GameObject TextCanvas;
    public XRBaseController RController;
    public XRBaseController LController;

    // Start is called before the first frame update
    void Start()
    {
        if(Managers.Game.ReturnTelephone()){
            TextCanvas.SetActive(false);
        }
    }

    public void GoToTelephone(){
        if(!Managers.Game.ReturnTelephone()){
            RController.SendHapticImpulse(0.5f, 0.5f);
            LController.SendHapticImpulse(0.5f, 0.5f);
            Managers.Game.changeScene(3);
        }
    }
}

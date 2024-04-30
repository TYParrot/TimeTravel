using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GameList : MonoBehaviour
{
    [SerializeField]
    public GameObject MicrowaveCheck;
    public GameObject RadioCheck;
    public GameObject TelephoneCheck;

    // Start is called before the first frame update
    void Start()
    {
        if(MicrowaveCheck == null){
            MicrowaveCheck = GameObject.Find("MicrowaveCheck");
        }
        if(RadioCheck == null){
            RadioCheck = GameObject.Find("RadioCheck");
        }
        if(TelephoneCheck == null){
            TelephoneCheck = GameObject.Find("TelephoneCheck");
        }
    }

    public void ActiveMicrowave(){
        MicrowaveCheck.SetActive(true);
    }
    
    public void ActiveRadio(){
        RadioCheck.SetActive(true);
    }

    public void ActiveTelephone(){
        TelephoneCheck.SetActive(true);
    }
}

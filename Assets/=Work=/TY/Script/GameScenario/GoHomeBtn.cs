using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class GoHomeBtn : MonoBehaviour
    {
        public void RadioToHome(){
            Managers.Game.ClearRadio(true);
            Managers.Game.changeScene(1);
        }

        public void MicrowaveToHome(){
            Managers.Game.ClearMicrowave(true);
            Managers.Game.changeScene(1);
        }

        public void TelephoneToHome(){
            Managers.Game.ClearTelephone(true);
            Managers.Game.changeScene(1);
        }
    }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game{
    public class ScenarioManager
    {
        private bool PlayIntro;
        private bool PlayRadio;
        private bool PlayMicrowave;
        private bool PlayTelephone;
        private bool PlayAllClear;

        public void Init(){
            PlayIntro = false;
            PlayRadio = false;
            PlayMicrowave = false;
            PlayTelephone = false;
            PlayAllClear = false;
        }

        //플레이 여부 반환 용도
        public bool ReturnPlayIntro(){
            return PlayIntro;
        }

        //플레이 여부 변환 용도
        public void ClearPlayIntro(bool clear){
            PlayIntro = true;
        }

        public bool ReturnPlayRadio(){
            return PlayRadio;
        }

        public void ClearPlayRadio(bool clear){
            PlayRadio = true;
        }

        public bool ReturnPlayMicrowave(){
            return PlayMicrowave;
        }

        public void ClearPlayMicrowave(bool clear){
            PlayMicrowave = true;
        }

        public bool ReturnPlayTelephone(){
            return PlayTelephone;
        }

        public void ClearPlayTelephone(bool clear){
            PlayTelephone = true;
        }

        public bool ReturnPlayAllClear(){
            return PlayAllClear;
        }

        public void ClearPlayAllClear(bool clear){
            PlayAllClear = true;
        }
    }
}

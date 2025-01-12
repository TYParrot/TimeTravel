using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV_PlayVideo : MonoBehaviour
{
    private int ClearGameCount = 0;
    private float PlaySpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
       CountClearGame();

        if(ClearGameCount != 0){
            PlaySpeed = Mathf.Round(10f / ClearGameCount) / 10f;
        }else{
            PlaySpeed = 0;
        }

        gameObject.GetComponent<VideoPlayer>().playbackSpeed = PlaySpeed;
        gameObject.GetComponent<VideoPlayer>().Play();
    }

    private void CountClearGame(){
        if(Managers.Scenario.ReturnPlayRadio()) ClearGameCount++;
        if(Managers.Scenario.ReturnPlayMicrowave()) ClearGameCount++;
        if(Managers.Scenario.ReturnPlayTelephone()) ClearGameCount++;
    }

}

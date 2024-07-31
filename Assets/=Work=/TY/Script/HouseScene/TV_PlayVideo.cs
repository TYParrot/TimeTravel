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
        }

        gameObject.GetComponent<VideoPlayer>().playbackSpeed = PlaySpeed;
        Debug.Log(gameObject.GetComponent<VideoPlayer>().playbackSpeed);
    }

    private void CountClearGame(){
        if(Managers.Scenario.ReturnPlayRadio()) ClearGameCount++;
        if(Managers.Scenario.ReturnPlayMicrowave()) ClearGameCount++;
        if(Managers.Scenario.ReturnPlayTelephone()) ClearGameCount++;
    }

}

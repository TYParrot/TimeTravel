using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

using UnityEngine.UI;

public class MicrowaveController : MonoBehaviour
{
    public Slider slider; 
    public Light pointLight; 
    private Button sliderButton;
    public AudioSource audioSource;
    public AudioSource backaudioSource;

    void Start(){
        if(backaudioSource != null){
            backaudioSource.loop = true;
            backaudioSource.Play();
        }
    }

    public void FillGauge(){
        slider.value += 0.05f;
    }
    public void SetIntensity(){
        pointLight.intensity=80;
        pointLight.range=50;
        PlaySoundForDuration(1.0f);
        Invoke("ResetIntensity", 1.0f);
    }
    public void ResetIntensity(){
        pointLight.intensity=0;
    }
    public void PlaySoundForDuration(float duration){
        if(audioSource != null){
            
            audioSource.Play();
            Invoke("ResumeBackMusic",duration);
        }
    }
    public void ResumeBackMusic(){
       
       if(audioSource!=null){
        audioSource.Stop();
       }
    }

    
}

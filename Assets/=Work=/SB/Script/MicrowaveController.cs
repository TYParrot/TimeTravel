using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class MicrowaveController : MonoBehaviour
{
    public Slider slider; 
    public Light pointLight; 
    private Button sliderButton;

    public void FillGauge(){
        slider.value += 0.1f;
    }
    public void SetIntensity(){
        pointLight.intensity=100;
        Invoke("ResetIntensity", 1.0f);
    }
    public void ResetIntensity(){
        pointLight.intensity=0;
    }

    
}

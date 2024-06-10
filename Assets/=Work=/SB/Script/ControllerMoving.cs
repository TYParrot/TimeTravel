using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

//컨트롤러의 움직임이 일정 거리 이상이면 게이지를 fill함.
public class ControllerMoving : MonoBehaviour
{
    private XRInteractorLineVisual lineVisual;
    private Vector3 previousPosition;
    private float checkInterval = 0.3f;
    private float timer = 0.0f;
    private float distance = 0;

    public MicrowaveController controllerScript;
    public GaugeController gaugeController;
    public UI_Micro UI;
    public GameObject mascoat;

    
    public XRBaseController Controller;

    // Start is called before the first frame update
    void Start()
    {
        previousPosition = transform.position;
        lineVisual = gameObject.GetComponent<XRInteractorLineVisual>();

    }

    // Update is called once per frame
    void Update()
    {

        if(!UI.returnIntroPlaying()){
            if(lineVisual.enabled){
                lineVisual.enabled = false;
            }

            if(!mascoat.activeSelf){
                mascoat.SetActive(true);
            }
            checkMoving();
        }

        if(gaugeController.returnGaugeFull()){
            lineVisual.enabled = true;
            this.enabled = false;
            mascoat.SetActive(false);
        }
    }

    void checkMoving(){
        timer += Time.deltaTime;

        if(timer >= checkInterval){
            distance = Vector3.Distance(transform.position, previousPosition);
            
            if(distance >= 0.08){
                Controller.SendHapticImpulse(0.5f, 0.5f);
                controllerScript.FillGauge();
                controllerScript.SetIntensity();
            }
            timer = 0.0f;
            previousPosition = transform.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

//해당 오브젝트의 클리어 여부에 따라서 텍스트 비활성화 혹은 클리어 표시가 추가 될 수 있습니다.
public class MicrowaveSetting : MonoBehaviour
{
    public GameObject TextCanvas;
    public XRBaseController RController;
    public XRBaseController LController;

    // Start is called before the first frame update
    void Start()
    {
        if(Managers.Game.ReturnMicrowave()){
            TextCanvas.SetActive(false);
        }
    }

    public void GoToMicrowave(){
        if(!Managers.Game.ReturnMicrowave()){
            RController.SendHapticImpulse(0.5f, 0.5f);
            LController.SendHapticImpulse(0.5f, 0.5f);
            Managers.Game.changeScene(4);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class StopChecking : MonoBehaviour
{
    private SphereCollider sphereCollider;
    public MovingBarController movingBar;
    public XRBaseController Controller;

    void Start(){
        sphereCollider = gameObject.GetComponent<SphereCollider>();
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Radio")){
            movingBar.clickBtn();
            Controller.SendHapticImpulse(0.5f, 0.5f);
            StartCoroutine(DisableCollider());
        }
    }

    IEnumerator DisableCollider(){
        sphereCollider.enabled = false;
        yield return new WaitForSeconds(0.5f);
        sphereCollider.enabled = true;
    }
}

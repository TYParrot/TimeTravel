using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditPanel : MonoBehaviour
{
    public GameObject mascot;
    private Animator animator;
    public GameObject ExCanvas;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1){
            mascot.SetActive(true);
            gameObject.SetActive(false);
            ExCanvas.SetActive(true);
        }
    }

    public void Setting(){
        mascot.SetActive(false);
        ExCanvas.SetActive(false);
    }
}

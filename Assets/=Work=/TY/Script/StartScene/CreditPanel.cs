using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditPanel : MonoBehaviour
{
    public GameObject mascoat;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        mascoat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1){
            mascoat.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}

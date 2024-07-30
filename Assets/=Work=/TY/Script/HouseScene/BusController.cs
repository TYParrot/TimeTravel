using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;

public class BusController : MonoBehaviour
{
    private bool isChecked = false;

    // Update is called once per frame
    void Update()
    {
        if (!isChecked)
        {
            if (Managers.Scenario.ReturnPlayAllClear())
            {
                // Animator 컴포넌트를 가져옴
                Animator animator = gameObject.GetComponent<Animator>();

                // Animator가 존재하면 AllClear 파라미터를 true로 설정
                if (animator != null)
                {
                    animator.SetBool("AllClear", true);
                }

                isChecked = true; // 한 번 설정 후 다시 체크하지 않도록 isChecked를 true로 변경
            }
        }
    }
}

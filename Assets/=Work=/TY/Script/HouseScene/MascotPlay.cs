using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//마스코트 active 및 클리어 효과까지 전부 여기서 관리할 예정
public class MascotPlay : MonoBehaviour
{
    public GameObject Mascots;
    public GameObject IntroPanel;
    public GameObject RadioPanel;
    public GameObject MicrowavePanel;
    public GameObject TelephonePanel;
    public GameObject AllClearPanel;

    // Update is called once per frame
    void Update()
    {
        if(IntroPanel.activeSelf || RadioPanel.activeSelf || MicrowavePanel.activeSelf || TelephonePanel.activeSelf || AllClearPanel.activeSelf){
            Mascots.SetActive(true);
        }else{
            Mascots.SetActive(false);
        }
    }
}

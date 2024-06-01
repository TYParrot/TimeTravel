using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Scenario : MonoBehaviour
{
    [SerializeField]
    public GameObject IntroPanel;
    public GameObject RadioPanel;
    public GameObject MicrowavePanel;
    public GameObject TelephonePanel;
    public GameObject AllClearPanel;

    //모두 클리어시 Start씬으로 돌아가는 버튼
    public GameObject GoHomeBtn;

    public GameObject particle;

    //자식 메세지들 저장용도
    private GameObject[] Msgs; 

    void Start()
    {
        PlayIntro();
        PlayRadio();
        PlayMicrowave();
        PlayTelephone();
    }

    void PlayIntro(){
        if(Managers.Scenario.ReturnPlayIntro() == false){
            Managers.Scenario.ClearPlayIntro(true);

            IntroPanel.SetActive(true);

            // 부모 오브젝트의 자식 오브젝트들을 배열에 저장
            Msgs = new GameObject[IntroPanel.transform.childCount];
            for (int i = 0; i < IntroPanel.transform.childCount; i++)
            {
                Msgs[i] = IntroPanel.transform.GetChild(i).gameObject;
            }

            // 코루틴을 통해 메시지 재생 시작
            StartCoroutine(PlayMessages());
        }
    }

    void PlayRadio(){
        if(Managers.Game.ReturnRadio() == true && Managers.Scenario.ReturnPlayRadio() == false){

            Managers.Scenario.ClearPlayRadio(true);

            RadioPanel.SetActive(true);

            Msgs = new GameObject[RadioPanel.transform.childCount];
            for (int i = 0; i < RadioPanel.transform.childCount; i++)
            {
                Msgs[i] = RadioPanel.transform.GetChild(i).gameObject;
            }

            StartCoroutine(PlayMessages());
        }
    }

    void PlayMicrowave(){
        if(Managers.Game.ReturnMicrowave() == true && Managers.Scenario.ReturnPlayMicrowave() == false){

            Managers.Scenario.ClearPlayMicrowave(true);

            MicrowavePanel.SetActive(true);

            Msgs = new GameObject[MicrowavePanel.transform.childCount];
            for (int i = 0; i < MicrowavePanel.transform.childCount; i++)
            {
                Msgs[i] = MicrowavePanel.transform.GetChild(i).gameObject;
            }

            StartCoroutine(PlayMessages());
        }
    }

    void PlayTelephone(){
        if(Managers.Game.ReturnTelephone() == true && Managers.Scenario.ReturnPlayTelephone() == false){

            Managers.Scenario.ClearPlayTelephone(true);

            TelephonePanel.SetActive(true);

            Msgs = new GameObject[TelephonePanel.transform.childCount];
            for (int i = 0; i < TelephonePanel.transform.childCount; i++)
            {
                Msgs[i] = TelephonePanel.transform.GetChild(i).gameObject;
            }

            StartCoroutine(PlayMessages());
        }
    }
    
    void PlayAllClear(){

        particle.SetActive(true);
        
        if(Managers.Game.ReturnMicrowave() && Managers.Game.ReturnRadio() && Managers.Game.ReturnTelephone() && Managers.Scenario.ReturnPlayAllClear() == false){

            AllClearPanel.SetActive(true);

            Msgs = new GameObject[AllClearPanel.transform.childCount];
            for (int i = 0; i < AllClearPanel.transform.childCount; i++)
            {
                Msgs[i] = AllClearPanel.transform.GetChild(i).gameObject;
            }

            StartCoroutine(PlayMessages());
            StartCoroutine(ShowGoHomeBtn());
            Managers.Scenario.ClearPlayAllClear(true);

        }

        
    }

    IEnumerator PlayMessages(){
        // 모든 메시지를 순차적으로 재생
        foreach (GameObject msg in Msgs){
            msg.SetActive(true); // 메시지 활성화

            // 재생 후 대기
            yield return new WaitForSeconds(5.0f); // 재생 시간
            msg.SetActive(false); // 메시지 비활성화
        }

        DeactivateAll();
        
        yield return new WaitForSeconds(1.0f);
        PlayAllClear();
    }

    IEnumerator ShowGoHomeBtn(){
        yield return new WaitForSeconds(12.0f);
        GoHomeBtn.SetActive(true);
    }

    void DeactivateAll(){
        IntroPanel.SetActive(false);
        RadioPanel.SetActive(false);
        MicrowavePanel.SetActive(false);
        TelephonePanel.SetActive(false);
        AllClearPanel.SetActive(false);
    }

    IEnumerator playParticle(){
        particle.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        particle.SetActive(false);
    }
}

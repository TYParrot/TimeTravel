using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Radio : MonoBehaviour
{
    // [SerializeField]
    public GameObject IntroPanel;
    public GameObject AllClearPanel;
    public GameObject ExplainPanel;

    //모두 클리어시 Start씬으로 돌아가는 버튼
    public GameObject GoHomeBtn;
    
    //게임 플레이시 마스코트, 뿅망치 활성화 필요
    public GameObject Mascot;
    public GameObject RightHand;
    public GameObject LeftHand;

    //자식 메세지들 저장용도
    private GameObject[] Msgs; 
    private bool isItStart = false;
    private int stage;
    private bool playAllClear = false;

    
    public GameObject particle;

    void Start()
    {   
        PlayIntro();
    }

    void PlayIntro(){
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
    

    public void PlayAllClear(){

        Mascot.SetActive(false);
        RightHand.SetActive(false);
        LeftHand.SetActive(false);

        StartCoroutine(playParticle());
        
        AllClearPanel.SetActive(true);
        playAllClear = true;

        Msgs = new GameObject[AllClearPanel.transform.childCount];
        for (int i = 0; i < AllClearPanel.transform.childCount; i++)
        {
            Msgs[i] = AllClearPanel.transform.GetChild(i).gameObject;
        }

        StartCoroutine(PlayMessages());
        StartCoroutine(ShowGoHomeBtn());
        
    }

    IEnumerator PlayMessages(){
        // 모든 메시지를 순차적으로 재생
        foreach (GameObject msg in Msgs){
            msg.SetActive(true); // 메시지 활성화

            // 재생 후 대기
            yield return new WaitForSeconds(5.0f); // 재생 시간
            
            if(!playAllClear){
                msg.SetActive(false); // 메시지 비활성화
            }
        }

        DeactivateAll();
        
        if(!isItStart){
            isItStart = true;
            ExplainPanel.SetActive(true);
            yield return new WaitForSeconds(5.0f);
            Mascot.SetActive(true);
            RightHand.SetActive(true);
            LeftHand.SetActive(true);

        }

        DeactivateAll();
    }

    IEnumerator ShowGoHomeBtn(){
        yield return new WaitForSeconds(3.0f);
        GoHomeBtn.SetActive(true);
    }

    void DeactivateAll(){
        IntroPanel.SetActive(false);
        ExplainPanel.SetActive(false);

    }
    
    IEnumerator playParticle(){
        particle.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        particle.SetActive(false);
    }
}

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


    //자식 메세지들 저장용도
    private GameObject[] Msgs; 
    private bool isItStart = false;
    private int stage;

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

        AllClearPanel.SetActive(true);

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
            msg.SetActive(false); // 메시지 비활성화
        }

        DeactivateAll();
        
        if(!isItStart){
            isItStart = true;
            ExplainPanel.SetActive(true);
            yield return new WaitForSeconds(5.0f);

        }

        DeactivateAll();
    }

    IEnumerator ShowGoHomeBtn(){
        yield return new WaitForSeconds(3.0f);
        GoHomeBtn.SetActive(true);
    }

    void DeactivateAll(){
        IntroPanel.SetActive(false);
        AllClearPanel.SetActive(false);
        ExplainPanel.SetActive(false);

    }
}

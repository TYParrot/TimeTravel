using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneScenario : MonoBehaviour
{
    [SerializeField]
    public GameObject IntroPanel;
    public GameObject ClearPanel;

    private GameObject[] Msgs;
    public GameObject GoHomeBtn;

    // Start is called before the first frame update
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

    void PlayClear(){
        ClearPanel.SetActive(true);

        // 부모 오브젝트의 자식 오브젝트들을 배열에 저장
        Msgs = new GameObject[ClearPanel.transform.childCount];
        for (int i = 0; i < ClearPanel.transform.childCount; i++)
        {
            Msgs[i] = ClearPanel.transform.GetChild(i).gameObject;
        }

        // 코루틴을 통해 메시지 재생 시작
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

        IntroPanel.SetActive(false);
    }

    IEnumerator ShowGoHomeBtn(){
        yield return new WaitForSeconds(5.0f);
        GoHomeBtn.SetActive(true);
    }

}

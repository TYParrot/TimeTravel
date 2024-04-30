using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//게임 클리어 이후, 시나리오 재생한 이후에, 클리어 메소드와 씬 전환 메소드를 호출해야함.
//해당 스크립트에서는 클리어 메소드 및 씬 전환 메소드를 진행하는 버튼을 active시키는 부분까지 적혀있음.
//버튼이 수행할 내용에 대한 스크립트는 따로 작성해야함.
//확장 및 수정은 다른 스크립트에서 진행할 것. ex) ExampleExtend : PlayScenario
//재생시간은 추후에 demo 플레이 해보면서 변경할 예정.
public class PlayScenario : MonoBehaviour
{
    
    //자식 메세지들 저장용도
    private GameObject[] Msgs; 
    private float Interval = 0;
    private GameObject Btn;

    public void PlayMsg(GameObject ParentOfMsgs, GameObject ClearBtn){
        
        Msgs = new GameObject[ParentOfMsgs.transform.childCount];
        Interval = 5.0f * (ParentOfMsgs.transform.childCount-1);
        
        Btn = ClearBtn;

        for(int i = 0; i<ParentOfMsgs.transform.childCount; i++){
            Msgs[i] = ParentOfMsgs.transform.GetChild(i).gameObject;
        }

        StartCoroutine(PlayMessages());
        StartCoroutine(ShowBtn());

    }

    IEnumerator ShowBtn(){
        yield return new WaitForSeconds(Interval);
        if(Btn == null){
            Debug.Log("활성화할 버튼 없음");
        }else{
            Btn.SetActive(true);
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

    }
}

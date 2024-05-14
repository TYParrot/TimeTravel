using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RadioManager : MonoBehaviour
{
    private static RadioManager _instance; // 싱글톤 인스턴스
    // UI_Radio uiRadioInstance = FindObjectOfType<UI_Radio>();
    public static event Action<int> StageChanged; // 스테이지 변경 이벤트
    private int currentStage = 1; // 현재 스테이지 번호

    // 게임 매니저의 인스턴스를 가져오는 프로퍼티
    public static RadioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                // 게임 매니저가 없으면 새로운 게임 매니저를 생성합니다.
                GameObject go = new GameObject("RadioManager");
                _instance = go.AddComponent<RadioManager>();
            }
            return _instance;
        }
    }

    // 현재 스테이지 번호를 반환하는 메서드
    public int GetCurrentStage()
    {
        return currentStage;
    }

    // 마우스 클릭 시 호출되는 메서드
    private void OnMouseDown()
    {
        IncrementStage(); // 스테이지 증가
    }

    // 현재 스테이지를 증가시키고 콘솔에 출력하는 메서드
    public void IncrementStage()
    {
        ///여기에 1초 딜레이 넣어줘
        currentStage++; // 스테이지 증가
        Debug.Log("현재 스테이지 번호: " + currentStage);

        // 스테이지 변경 이벤트를 호출합니다.
        if (StageChanged != null)
        {
            StageChanged?.Invoke(currentStage);
        }
    }

    // 스테이지를 설정하는 메서드
    public void SetCurrentStage(int stage)
    {
        currentStage = stage;
    }

    void Awake()
    {
        // 다른 GameManager가 이미 존재하는지 확인하고, 새로 생성된 경우 이 인스턴스를 유지합니다.
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // MovingBarController를 멤버 변수로 선언합니다.
    public MovingBarController movingBarController;
    public UI_Radio uiRadioInstance;


    void Start()
    {
        Managers.Game.SceneSetting();

        // MovingBarController를 초기화합니다.
        movingBarController = FindObjectOfType<MovingBarController>();
        uiRadioInstance = FindObjectOfType<UI_Radio>();

        if (movingBarController != null)
        {
            // 추가적인 초기화가 필요한 경우 여기에 작성합니다.
        }
        else
        {
            Debug.LogError("MovingBarController를 찾을 수 없습니다!");
        }
    }

    void Update()
    {
        // 현재 스테이지가 3 이하인 경우 MovingBarController의 Update 함수를 호출합니다.
        if (currentStage <= 3)
        {
            if (movingBarController != null)
            {
                movingBarController.Update();
            }
        }
        else
        {
            
            uiRadioInstance.PlayAllClear();
            movingBarController.setMusic(); // 스테이지가 3을 초과하면 노래 씬으로 전환합니다.
        }
    }
}

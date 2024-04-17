using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RadioManager : MonoBehaviour
{
    private static RadioManager _instance; // 싱글톤 인스턴스
    public static event Action<int> StageChanged;
    private int currentStage = 1; // 현재 스테이지 번호
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

    public int GetCurrentStage()
    {
        return currentStage;
    }
    
    // 마우스 클릭 시 호출되는 메서드
    private void OnMouseDown()
    {
        IncrementStage();
    }

    // 현재 스테이지를 증가시키고 콘솔에 출력하는 메서드
    private void IncrementStage()
    {
        currentStage++;
        Debug.Log("현재 스테이지 번호: " + currentStage);

        // 스테이지 변경 이벤트를 호출합니다.
        if (StageChanged != null)
        {
            StageChanged?.Invoke(currentStage);
        }
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
    public BallColorChanger stageColorController;

    void Start()
    {
        // MovingBarController를 초기화합니다.
        movingBarController = FindObjectOfType<MovingBarController>();
        stageColorController = FindObjectOfType<BallColorChanger>();

        // MovingBarController가 null이 아닌 경우에만 설정합니다.
        if (movingBarController != null)
        {
            // 필요한 설정을 수행합니다.
            // 예를 들어, speed 값을 변경할 수 있습니다.
            movingBarController.speed = 2.0f;
        }
        else
        {
            Debug.LogError("MovingBarController를 찾을 수 없습니다!");
        }
    }

    void Update()
    {
        // 필요한 경우 MovingBarController의 Update 함수를 호출합니다.
        if (movingBarController != null)
        {
            movingBarController.Update();
        }

        if (stageColorController != null)
        {
            stageColorController.Update();
        }

        // 매 프레임마다 현재 스테이지 번호를 콘솔에 출력합니다.
        Debug.Log("현재 스테이지 번호: " + currentStage);
    }
}

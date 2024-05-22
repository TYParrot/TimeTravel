using UnityEngine;
using System.Collections;

/*
라디오 게임은 크게 3개의 씬으로 나뉩니다.
각 씬은 game_rule_scene, game_scene, music_scene으로 구성됩니다.
씬이 전환되는 것처럼 보이게 하기 위해 각 씬에 해당하는 오브젝트의 active 값을 조정합니다.

game_rule_scene:
게임 설명 오브젝트가 표시됩니다. 시작 버튼을 누르면 게임 설명 오브젝트가 사라집니다.

game_scene:
게임은 3단계로 구성되어 있습니다. 
각 단계에 따라 target_bar의 위치와 크기가 다릅니다.
현재 단계는 화면 상단의 라디오 오브젝트 색이 흑백에서 컬러로 전환되면서 표시됩니다.
게임이 진행되면 moving_bar가 star_bar와 end_bar 사이를 왕복 운동합니다.
moving_bar가 target_bar와 일정 거리 이하에 위치해 있을 때 컨트롤러를 클릭하면
성공 오브젝트가 0.6초간 화면에 나타납니다. 반대로 일정 거리 이상이면 실패 오브젝트가 화면에 나타납니다.
3단계까지 완료되면 music_scene으로 넘어갑니다.

music_scene:
실제 라디오 오디오가 흘러나옵니다. 오디오는 약 50초 길이이며,
50초 후 Managers.Game.ClearRadio(); Managers.Game.changeScene(1);가 자동으로 호출됩니다.
*/

public class MovingBarController : MonoBehaviour
{
    // game_rule_scene 관련 변수
    private GameObject gameRuleObject; // 게임 설명 오브젝트를 참조하기 위한 변수

    // game_scene 관련 변수
    private GameObject gameSceneObject; // 게임 씬 오브젝트를 참조하기 위한 변수
    private int stage; // 현재 게임 단계를 나타내는 변수
    public Transform startBar;  // 시작 바의 위치를 나타내는 Transform
    public Transform endBar;    // 끝 바의 위치를 나타내는 Transform
    public Transform movingBar; // 이동 바의 위치를 나타내는 Transform
    public Transform[] targetBars; // 타겟 바들의 위치를 나타내는 배열
    public Transform[] StageBalls;  // 스테이지 공들을 나타내는 배열
    private float speed = 1f;    // 바 이동 속도
    private Vector3 startMarker; // 시작 지점 마커
    private Vector3 endMarker;   // 끝 지점 마커
    private bool movingToEnd = true; // 바가 이동 방향을 나타내는 플래그
    private bool movementPaused = false; // 바의 움직임이 일시 중지되었는지 나타내는 플래그
    private bool successAchieved = false; // 성공 여부를 나타내는 플래그
    private bool gameRuleShow = true;     // 게임 설명이 표시되고 있는지 나타내는 플래그
    private bool fail = false;            // 실패 여부를 나타내는 플래그
    private GameObject succObject;        // 성공 오브젝트
    private GameObject failObject;        // 실패 오브젝트
    private GameObject colorObject;       // 색상 오브젝트
    public Color originalRadioColor;      // 라디오의 원래 색상
    public bool pausedBtn = false;      //k 인풋 대용 버튼

    // music_scene 관련 변수
    private GameObject musicSceneObject; // 음악 씬 오브젝트를 참조하기 위한 변수

    private void Start()
    {   
        // 게임 오브젝트 초기화
        gameRuleObject = GameObject.Find("game_rule_scene"); // 게임 설명 오브젝트 찾기
        gameSceneObject = GameObject.Find("game_scene"); // 게임 씬 오브젝트 찾기
        startMarker = startBar.position; // 시작 지점 마커 설정
        endMarker = endBar.position;     // 끝 지점 마커 설정
        succObject = GameObject.Find("succ"); // 성공 오브젝트 찾기
        failObject = GameObject.Find("fail"); // 실패 오브젝트 찾기
        colorObject = GameObject.Find("RadioBackBody"); // 색상 오브젝트 찾기
        musicSceneObject = GameObject.Find("music_scene"); // 음악 씬 오브젝트 찾기

        // 성공 및 실패 오브젝트 비활성화
        if (succObject != null && !successAchieved)
        {
            succObject.SetActive(false);
        }

        if (failObject != null && !fail)
        {
            failObject.SetActive(false);
        }
        if (musicSceneObject != null)
        {
            musicSceneObject.SetActive(false);
        }
        
        // 라디오 오브젝트의 초기 색상 저장
        if (colorObject != null)
        {
            Renderer renderer = colorObject.GetComponent<Renderer>();
            originalRadioColor = colorObject.GetComponent<Renderer>().material.color;
        }
    }

    public void Update()
    {
        // 게임 씬이 3단계 이하인 경우
        if (stage <= 3)
        {
            // 현재 단계 설정 및 타겟 바 및 스테이지 공 표시
            stage = RadioManager.Instance.GetCurrentStage();
            ShowTargetBarStage(stage);
            ShowStageBall(stage);

            // 움직이는 바의 움직임 처리
            if (!IsMovementPaused())
            {
                Vector3 targetMarker = movingToEnd ? endMarker : startMarker;
                Vector3 direction = targetMarker - movingBar.position;
                float step = speed * Time.deltaTime;

                movingBar.position += direction.normalized * step;

                // if (Vector3.Distance(movingBar.position, targetMarker) < 0.01f)
                if (Vector3.Distance(movingBar.position, targetMarker) < 0.1f)
                {
                    movingToEnd = !movingToEnd;
                }

            }
            else
            {
                // 움직임이 일시 중지된 경우
                if (!movementPaused)
                {
                    Debug.Log("이벤트 발생(k클릭)");
                    int targetIndex = (stage - 1) % targetBars.Length;
                    Transform targetBar = targetBars[targetIndex];

                    // 클릭 이벤트 처리
                    // if (Vector3.Distance(movingBar.position, targetBar.position) < 0.5f)
                    if (Vector3.Distance(movingBar.position, targetBar.position) < 3f)
                    {
                        succObject.SetActive(true);
                        StartCoroutine(HideAfterDelay(succObject, 0.6f));;
                        successAchieved = true; // 성공 여부 플래그 설정
                        HandleStageChanged(stage); // 스테이지 변경 처리
                        RadioManager.Instance.IncrementStage();

                    }
                    else
                    {
                        if (!succObject.activeSelf)
                        {
                            Debug.Log(Vector3.Distance(movingBar.position, targetBar.position));
                            // 실패 조건 처리
                            failObject.SetActive(true);
                            StartCoroutine(HideAfterDelay(failObject, 0.6f));
                        }
                    }
                }
            }
        }
        else if (stage == 4)
        {
            // music 씬 설정
            setMusic();
            musicSceneObject.SetActive(true);
        }
        else
        {
            Debug.Log("잘못된 stage num");
        }
    }

    public void clickBtn(){
        pausedBtn =true;
    }

    private bool IsMovementPaused()
    {
        if(pausedBtn)StartCoroutine(pauseBtn());
        return pausedBtn; 
    }

    public IEnumerator pauseBtn(){
        yield return null;
        pausedBtn = false;
    }

    private System.Collections.IEnumerator PauseMovement(float pauseTime)
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(pauseTime);
        Time.timeScale = 1f;
    }

    public void ShowTargetBarStage(int stage)
    {
        foreach (Transform targetBar in targetBars)
        {
            targetBar.gameObject.SetActive(false); // 모든 타겟 바 비활성화
        }
        int targetIndex = (stage - 1) % targetBars.Length;
        targetBars[targetIndex].gameObject.SetActive(true); // 현재 스테이지에 해당하는 타겟 바 활성화
    }

    public void ShowStageBall(int stage)
    {
        foreach (Transform stageBall in StageBalls)
        {
            stageBall.GetComponent<Renderer>().material.color = Color.gray; // 모든 스테이지 공 색상을 회색으로 설정
        }

        switch (stage)
        {
            case 1:
                StageBalls[0].GetComponent<Renderer>().material.color = originalRadioColor; // 1단계일 때 스테이지 공 색상을 라디오의 원래 색상으로 설정
                break;
            case 2:
                StageBalls[0].GetComponent<Renderer>().material.color = originalRadioColor; // 2단계일 때 스테이지 공 색상을 라디오의 원래 색상으로 설정
                StageBalls[1].GetComponent<Renderer>().material.color = originalRadioColor;
                break;
            case 3:
                StageBalls[0].GetComponent<Renderer>().material.color = originalRadioColor; // 3단계일 때 스테이지 공 색상을 라디오의 원래 색상으로 설정
                StageBalls[1].GetComponent<Renderer>().material.color = originalRadioColor;
                StageBalls[2].GetComponent<Renderer>().material.color = originalRadioColor;
                break;
            default:
                break;
        }
    }

    private void HandleStageChanged(int stage)
    {
        // 게임 오브젝트들을 정지시키고 스테이지 변경 처리를 수행합니다.
        Time.timeScale = 0f; // 시간 스케일을 정지하여 게임 오브젝트의 모든 동작을 정지
        ShowTargetBarStage(stage); // 현재 스테이지에 해당하는 타겟 바 표시
        ShowStageBall(stage);      // 현재 스테이지에 해당하는 스테이지 공 표시

        // 스테이지 변경 전에 0.3초간 정지 후 다시 재개합니다.
        StartCoroutine(ResumeAfterDelay(0.3f));
    }

    public IEnumerator ResumeAfterDelay(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        // 정지된 시간을 다시 재개합니다.
        Time.timeScale = 1f;
    }

    public IEnumerator HideAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSecondsRealtime(delay);

        // obj가 null이 아닌지 확인하고 유효성 검사를 수행합니다.
        if (obj != null)
        {
            // 지연 후 오브젝트를 다시 비활성화합니다.
            obj.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Object to hide is null.");
        }
    }

    public void setMusic()
    {  
        // 게임 씬 비활성화 및 노래 씬 활성화
        gameSceneObject.SetActive(false);
        musicSceneObject.SetActive(true);
        StartCoroutine(CallClearRadioAfterDelay(50f)); // 50초 후 ClearRadio 함수 호출
    }

    IEnumerator CallClearRadioAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Managers.Game의 ClearRadio 함수 호출
        // Managers.Game.ClearRadio(true);
        // Managers.Game.changeScene(1);
        Debug.Log("ClearRadio 호출");
    }
}

using UnityEngine;
using System.Collections;


public class MovingBarController : MonoBehaviour
{
    public Transform startBar;
    public Transform endBar;
    public Transform movingBar;
    // public Transform successText;
    public Transform[] targetBars; // targetBar 배열로 변경합니다.
    public Transform[] StageBalls;

    public float speed = 8.0f;
    private Vector3 startMarker;
    private Vector3 endMarker;
    private bool movingToEnd = true;
    private int stage;
    private bool movementPaused = false;
    private bool successAchieved = false;
    private bool fail = false;
    private GameObject succObject;
    private GameObject failObject;


    private void Start()
    {
        succObject = GameObject.Find("succ");
        failObject = GameObject.Find("fail");

        // succ 오브젝트가 존재하고 성공 조건이 아직 충족되지 않았을 때만 비활성화합니다.
        if (succObject != null && !successAchieved)
        {
            succObject.SetActive(false);
        }

        if (failObject != null && !fail)
        {
            failObject.SetActive(false);
        }

        startMarker = startBar.position;
        endMarker = endBar.position;
        succObject.SetActive(false);
    }

    public void Update()
    {
        stage = RadioManager.Instance.GetCurrentStage();
        ShowTargetBarStage(stage);
        ShowStageBall(stage);

        if (!IsMovementPaused())
        {
            Vector3 targetMarker = movingToEnd ? endMarker : startMarker;
            Vector3 direction = targetMarker - movingBar.position;
            float step = speed * Time.deltaTime;

            movingBar.position += direction.normalized * step;

            if (Vector3.Distance(movingBar.position, targetMarker) < 0.01f)
            {
                movingToEnd = !movingToEnd;
            }

        }
        else
        {
            if (!movementPaused)
            {
                Debug.Log("k 클릭");

                // stage에 따라 올바른 targetBar를 선택합니다.
                int targetIndex = (stage - 1) % targetBars.Length;
                Transform targetBar = targetBars[targetIndex];

                if (Vector3.Distance(movingBar.position, targetBar.position) < 0.5f)
                {
                    // 성공 조건을 충족했을 때의 처리
                    succObject.SetActive(true);
                    StartCoroutine(HideAfterDelay(succObject, 0.3f));
                    Debug.Log("succ 활성화 됨");
                    successAchieved = true; // 성공 여부 플래그를 설정
                    HandleStageChanged(stage); // 스테이지 변경 처리
                    RadioManager.Instance.IncrementStage();

                }

                else
                {
                    if (!succObject.activeSelf)
                    {
                        // 실패 조건을 처리
                        failObject.SetActive(true);
                        Debug.Log("fail 활성화 됨");
                        StartCoroutine(HideAfterDelay(failObject, 0.3f));
                    }
                }
            }
        }
    }

    private bool IsMovementPaused()
    {
        return Input.GetKey(KeyCode.K);
    }


    private System.Collections.IEnumerator PauseMovement(float pauseTime)
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(pauseTime);
        Time.timeScale = 1f;
    }

    public void ShowTargetBarStage(int stage)
    {
        // 모든 타깃 바를 숨깁니다.
        foreach (Transform targetBar in targetBars)
        {
            targetBar.gameObject.SetActive(false);
        }

        // 현재 스테이지에 맞는 타깃 바를 보이도록 설정합니다.
        int targetIndex = (stage - 1) % targetBars.Length;
        targetBars[targetIndex].gameObject.SetActive(true);
    }


    public void ShowStageBall(int stage)
    {

        foreach (Transform stageBall in StageBalls)
        {
            stageBall.GetComponent<Renderer>().material.color = Color.gray;
        }

        int targetIndex = (stage - 1) % StageBalls.Length;
        StageBalls[targetIndex].gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
    private void HandleStageChanged(int stage)
    {
        // 나머지 오브젝트들은 정지합니다.
        Time.timeScale = 0f;

        Debug.Log("올바른 위치에서 멈췄습니다. 현재 스테이지: " + stage);
        ShowTargetBarStage(stage);
        ShowStageBall(stage);

        // 스테이지 변경 전에 1초간 정지 후 다시 재개합니다.
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
        // 지연 후 오브젝트를 다시 비활성화합니다.
        obj.SetActive(false);
        Debug.Log("비활성화 됨");
    }


}

using UnityEngine;

public class MovingBarController : MonoBehaviour
{
    public Transform startBar;
    public Transform endBar;
    public Transform movingBar;
    // public Transform initialPosition;
    public float speed = 1.0f;
    private Vector3 startMarker;
    private Vector3 endMarker;
    private bool movingToEnd = true;
    private GameObject[] targetBarStages;

    private void Start()
    {
        startMarker = startBar.position;
        endMarker = endBar.position;
        // movingBar.position = initialPosition.position;

        // Target bar stages 초기화
        targetBarStages = new GameObject[3];
        for (int i = 0; i < targetBarStages.Length; i++)
        {

            targetBarStages[i] = GameObject.Find("target_bar_stage" + (i + 1));
        }
    }

    public void Update()
    {
        // 키보드 "K"를 누르고 있는 동안 이동을 멈춥니다.
        if (!IsMovementPaused())
        {
            Debug.Log("k 클릭");
            Vector3 targetMarker = movingToEnd ? endMarker : startMarker;
            Vector3 direction = targetMarker - movingBar.position;
            float step = speed * Time.deltaTime;

            movingBar.position += direction.normalized * step;

            if (Vector3.Distance(movingBar.position, targetMarker) < 0.01f)
            {
                movingToEnd = !movingToEnd;
            }
        }

        // 스테이지 변경 이벤트 핸들러 호출
        int stage = RadioManager.Instance.GetCurrentStage();
        HandleStageChanged(stage);
    }

    // 키보드 "K"를 누르고 있는지 확인하는 메서드
    private bool IsMovementPaused()
    {
        return Input.GetKey(KeyCode.K);
    }

    private void HandleStageChanged(int stage)
    {
        Debug.Log("무빙바 스테이지가 변경되었습니다. 현재 스테이지: " + stage);
        ShowTargetBarStage(stage);
    }

    private System.Collections.IEnumerator PauseMovement(float pauseTime)
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(pauseTime);
        Time.timeScale = 1f;
    }

    public void ShowTargetBarStage(int stage)
    {
        for (int i = 0; i < targetBarStages.Length; i++)
        {
            targetBarStages[i].SetActive(i == (stage - 1));
        }
    }
}

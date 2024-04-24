using UnityEngine;

public class MovingBarController : MonoBehaviour
{
    public Transform startBar;
    public Transform endBar;
    public Transform movingBar;
    public Transform[] targetBars; // targetBar 배열로 변경합니다.
    public Transform[] StageBalls;

    public float speed = 8.0f;
    private Vector3 startMarker;
    private Vector3 endMarker;
    private bool movingToEnd = true;
    private int stage; 
    private bool movementPaused = false; 

    private void Start()
    {
        startMarker = startBar.position;
        endMarker = endBar.position;
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
                    HandleStageChanged(stage);
                    RadioManager.Instance.IncrementStage();
                    // movementPaused = true; 
                }
            }
        }
    }

    private bool IsMovementPaused()
    {
        return Input.GetKey(KeyCode.K);
    }

    private void HandleStageChanged(int stage)
    {
        Debug.Log("올바른 위치에서 멈췄습니다. 현재 스테이지: " + stage);
        ShowTargetBarStage(stage);
        ShowStageBall(stage);
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
        // 모든 타깃 바를 숨깁니다.
        // foreach (Transform StageBall in StageBalls)
        // {
        //     StageBall.gameObject.SetActive(false);
        // }

        // // 현재 스테이지에 맞는 타깃 바를 보이도록 설정합니다.
        // int targetIndex = (stage - 1) % StageBalls.Length;
        // targetBars[targetIndex].gameObject.SetActive(true);
        // 현재 스테이지에 맞는 타겟 바를 녹색으로 변경합니다.
        

        foreach (Transform stageBall in StageBalls)
        {
            stageBall.GetComponent<Renderer>().material.color = Color.gray;
        }

        int targetIndex = (stage - 1) % StageBalls.Length;
        StageBalls[targetIndex].gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}

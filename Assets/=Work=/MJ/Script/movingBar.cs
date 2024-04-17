using UnityEngine;

public class MovingBarController : MonoBehaviour
{
    public Transform startBar;
    public Transform endBar;
    public Transform movingBar;
    
    // moving_bar의 시작 위치
    public Transform initialPosition;

    // 움직이는 바의 속도
    public float speed = 1.0f;

    private Vector3 startMarker;
    private Vector3 endMarker;
    private bool movingToEnd = true;

    void Start()
    {
        startMarker = startBar.position;
        endMarker = endBar.position;
        movingBar.position = initialPosition.position; // 초기 위치 설정
    }

    public void Update()
    {
        // 현재 방향의 목표 지점 설정
        Vector3 targetMarker = movingToEnd ? endMarker : startMarker;

        // 이동 방향 설정
        Vector3 direction = targetMarker - movingBar.position;

        // 이동 속도 계산
        float step = speed * Time.deltaTime;

        // 이동
        movingBar.position += direction.normalized * step;

        // 목표 지점에 도달했을 때 방향 변경
        if (Vector3.Distance(movingBar.position, targetMarker) < 0.01f)
        {
            movingToEnd = !movingToEnd;
        }
    }

    // 오른쪽 컨트롤을 클릭하여 이동을 일시적으로 멈춥니다.
    private void OnMouseDown()
    {
        // 클릭된 오브젝트의 이름이 right_ctrl이면 이동을 멈춥니다.
        if (gameObject.name == "right_ctrl")
        {   
            Debug.LogError("right_ctrl 클릭");
            StartCoroutine(PauseMovement(1f)); // 0.1초 동안 이동을 멈춥니다.
        }
    }

    // 이동을 멈춘 후 재개합니다.
    private System.Collections.IEnumerator PauseMovement(float pauseTime)
    {
        Time.timeScale = 0f; // 시간 흐름을 멈춥니다.
        yield return new WaitForSecondsRealtime(pauseTime); // 지정된 시간만큼 대기합니다.
        Time.timeScale = 1f; // 시간 흐름을 다시 시작합니다.
    }
}

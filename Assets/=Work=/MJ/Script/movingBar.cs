/*
작성자 : 손민지
작성일 : 2024.04.06
*/

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

    void Update()
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
}

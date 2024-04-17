using UnityEngine;

public class BallColorChanger : MonoBehaviour
{
    private GameObject[] balls; // 모든 공을 저장할 배열

    private void OnEnable()
    {
        RadioManager.StageChanged += HandleStageChanged; // 스테이지 변경 이벤트에 구독합니다.
    }

    private void OnDisable()
    {
        RadioManager.StageChanged -= HandleStageChanged; // 스테이지 변경 이벤트에 구독을 해제합니다.
    }

    // 스테이지 변경 이벤트 핸들러
    private void HandleStageChanged(int stage)
    {
        // 여기에 스테이지 변경에 대한 처리 코드를 작성합니다.
        Debug.Log("스테이지가 변경되었습니다. 현재 스테이지: " + stage);
        // 다음과 같이 공의 색상을 변경하는 코드를 여기에 추가할 수 있습니다.
        ChangeBallColor();
    }

    private void Start()
    {
        // // 시작할 때 공들을 찾아 배열에 저장합니다.
        balls = new GameObject[3]; // 3개의 공을 가정합니다.
        balls[0] = GameObject.Find("lv1_sphere");
        balls[1] = GameObject.Find("lv2_sphere");
        balls[2] = GameObject.Find("lv3_sphere");
        Debug.Log("초기화 완료");
        // ChangeBallColor(); // 공의 색상을 변경합니다.
    }

    public void Update()
    {
        // // 시작할 때 공들을 찾아 배열에 저장합니다.
        balls = new GameObject[3]; // 3개의 공을 가정합니다.
        balls[0] = GameObject.Find("lv1_sphere");
        balls[1] = GameObject.Find("lv2_sphere");
        balls[2] = GameObject.Find("lv3_sphere");
        Debug.Log("업데이트");
        ChangeBallColor(); // 공의 색상을 변경합니다.
    }



    // 게임 중 스테이지가 변경될 때마다 호출될 메서드
    // public void IncrementStage()
    // {
    //     ChangeBallColor(); // 스테이지에 해당하는 공의 색을 변경합니다.
    // }

    private void ChangeBallColor()
    {
        // 현재 스테이지를 가져옵니다.
        int stage_num = RadioManager.Instance.GetCurrentStage();

        // 스테이지에 따라 공의 색상을 변경합니다.
        switch (stage_num%4)
        {
            case 1:
                ChangeColorForStage(0, Color.green, Color.gray, Color.gray);
                break;
            case 2:
                ChangeColorForStage(0, Color.gray, Color.green, Color.gray);
                break;
            case 3:
                ChangeColorForStage(0, Color.gray, Color.gray, Color.green);
                break;
            default:
                ChangeColorForStage(0, Color.gray, Color.gray, Color.gray);
                break;
        }
    }

    // 스테이지에 따라 공의 색상을 변경하는 메서드
    private void ChangeColorForStage(int ballIndex, Color color1, Color color2, Color color3)
    {
        if (ballIndex >= 0 && ballIndex < balls.Length && balls[ballIndex] != null)
        {
            // 공의 색상을 변경합니다.
            balls[ballIndex].GetComponent<Renderer>().material.color = color1;
            balls[(ballIndex + 1) % balls.Length].GetComponent<Renderer>().material.color = color2;
            balls[(ballIndex + 2) % balls.Length].GetComponent<Renderer>().material.color = color3;
        }
        else
        {
            Debug.LogError("Ball not found for stage " + (ballIndex + 1));
        }
    }
}

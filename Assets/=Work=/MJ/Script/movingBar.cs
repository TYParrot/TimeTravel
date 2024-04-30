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

    public float speed = 0.01f;
    private Vector3 startMarker;
    private Vector3 endMarker;
    private bool movingToEnd = true;
    private int stage;
    private bool movementPaused = false;
    private bool successAchieved = false;
    private bool gameRuleShow = true;
    private bool fail = false;
    private GameObject succObject;
    private GameObject failObject;
    private GameObject gameRuleObject;
    private GameObject gameSceneObject;
    private GameObject musicSceneObject;
    private GameObject colorObject;

    private GameObject beforeFinger;
    private GameObject afterFinger;
    private GameObject fadeObject;

    public Color originalRadioColor;
    private bool isRadioGray = false;
    public float fadeSpeed = 1.0f; // 페이드 속도를 조절합니다.

    public AudioClip m4aClip;
    private AudioSource audioSource;

    private void Start()
    {

        succObject = GameObject.Find("succ");
        failObject = GameObject.Find("fail");
        gameRuleObject = GameObject.Find("game_rule");
        gameSceneObject = GameObject.Find("game_scene");
        musicSceneObject = GameObject.Find("music_scene");
        fadeObject = GameObject.Find("fade");
        beforeFinger = GameObject.Find("before");
        afterFinger = GameObject.Find("after");
        fadeObject.SetActive(false);
        colorObject = GameObject.Find("RadioBackBody");

        // screenFade = GetComponent<ScreenFade>();

        // succ 오브젝트가 존재하고 성공 조건이 아직 충족되지 않았을 때만 비활성화합니다.
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

        if (gameRuleObject != null && gameRuleShow)
        {
            gameRuleObject.SetActive(true);
            StartCoroutine(HideAfterDelay(gameRuleObject, 5f));
            gameRuleShow = false;
        }

        // GameObject taggedObject = GameObject.FindGameObjectWithTag("Radio");///
        if (colorObject != null)
        {
            Renderer renderer = colorObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                // originalRadioColor = renderer.material.color;
                // colorObject.GetComponent<Renderer>().material.color = originalRadioColor;
                originalRadioColor = colorObject.GetComponent<Renderer>().material.color;
            }
            else
            {
                Debug.LogError("Renderer component not found on the object with the 'Radio' tag.");
            }
        }
        else
        {
            Debug.LogError("오브젝트 못찾음");
        }


        startMarker = startBar.position;
        endMarker = endBar.position;
        succObject.SetActive(false);
    }

    public void Update()
    {
        colorObject = GameObject.Find("RadioBackBody");
        if (colorObject != null)
        {
            Renderer renderer = colorObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                // originalRadioColor = renderer.material.color;
                // colorObject.GetComponent<Renderer>().material.color = originalRadioColor;
                originalRadioColor = colorObject.GetComponent<Renderer>().material.color;
            }
            else
            {
                Debug.LogError("Renderer component not found on the object with the 'Radio' tag.");
            }
        }
        else
        {
            Debug.LogError("오브젝트 못찾음");
        }

        if (stage <= 3)
        {
            StartCoroutine(HideAfterDelay(gameRuleObject, 10f));
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
                        StartCoroutine(HideAfterDelay(succObject, 0.6f));
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
                            StartCoroutine(HideAfterDelay(failObject, 0.6f));
                            Debug.Log("fail 활성화 됨");
                        }
                    }
                }
            }
        }
        else if (stage == 4)
        { //stage 4가 됐을 때 
            setMusic();
            // gameRuleObject.SetActive(false);
            // gameSceneObject.SetActive(false);
            // musicSceneObject.SetActive(true);
        }
        else
        {
            Debug.Log("hello");
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

        switch (stage)
        {
            case 1:
                StageBalls[0].GetComponent<Renderer>().material.color = originalRadioColor;
                break;
            case 2:
                StageBalls[0].GetComponent<Renderer>().material.color = originalRadioColor;
                StageBalls[1].GetComponent<Renderer>().material.color = originalRadioColor;
                break;
            case 3:
                StageBalls[0].GetComponent<Renderer>().material.color = originalRadioColor;
                StageBalls[1].GetComponent<Renderer>().material.color = originalRadioColor;
                StageBalls[2].GetComponent<Renderer>().material.color = originalRadioColor;
                break;
            default:
                // Debug.LogError("Invalid stage number.");
                break;
        }
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

        // obj가 null이 아닌지 확인하고 유효성 검사를 수행합니다.
        if (obj != null)
        {
            // 지연 후 오브젝트를 다시 비활성화합니다.
            obj.SetActive(false);
            Debug.Log("비활성화 됨");
        }
        else
        {
            Debug.LogWarning("Object to hide is null.");
        }
    }

    //// 스테이지 4가 되면(라디오 에서 관리) 라디오 듣는 씬 틀어야 함 나머지는 ek active false 로;
    public void setMusic()
    {
        // screenFade.FadeIn();
        // fadeObject.SetActive(true);

        // FadeOut();
        // gameRuleObject.SetActive(false);
        gameSceneObject.SetActive(false);
        afterFinger.SetActive(false);
        musicSceneObject.SetActive(true);
        afterFinger.SetActive(false);
        // HideAfterDelay(afterFinger, 0.001f);
        StartCoroutine(HideAfterDelay(beforeFinger, 6f));
        afterFinger.SetActive(true);


        StartCoroutine(CallClearRadioAfterDelay(30f));



    }


    // public void FadeIn()
    // {
    //     StartCoroutine(Fade(1f, 0f));
    // }

    // // 페이드아웃 효과를 적용합니다.
    // public void FadeOut()
    // {
    //     StartCoroutine(Fade(0f, 1f));
    // }

    // 검은 패널의 알파값을 변경하여 페이드 효과를 구현합니다.
    // IEnumerator Fade(float startAlpha, float endAlpha)
    // {
    //     float elapsedTime = 0f;
    //     Color startColor = fadeObject.GetComponent<Renderer>().material.color;
    //     Color endColor = new Color(startColor.r, startColor.g, startColor.b, endAlpha);

    //     while (elapsedTime < fadeSpeed)
    //     {
    //         fadeObject.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, elapsedTime / fadeSpeed);
    //         elapsedTime += Time.deltaTime;
    //         yield return null;
    //     }

    //     fadeObject.GetComponent<Renderer>().material.color = endColor;
    // }
    IEnumerator CallClearRadioAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Managers.Game의 ClearRadio 함수 호출
        // Managers.Game.ClearRadio();
        Debug.Log("클리어 라디오 호출 되었음");
    }

}

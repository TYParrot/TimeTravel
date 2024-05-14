using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProPlay : MonoBehaviour
{
    public GameObject StoryPanel;
    private GameObject[] StoryUI;

    public float fadeInTime = 1.0f; // 페이드 인 시간
    public float fadeOutTime = 1.0f; // 페이드 아웃 시간
    public float displayTime = 4.0f; // 화면에 표시되는 시간

    void Start()
    {
        StoryPanel.SetActive(true);

        StoryUI = new GameObject[StoryPanel.transform.childCount];

        for (int i = 0; i < StoryPanel.transform.childCount; i++)
        {
            StoryUI[i] = StoryPanel.transform.GetChild(i).gameObject;
        }

        StartCoroutine(StoryPlay());
    }

    private IEnumerator StoryPlay()
    {
        foreach (GameObject story in StoryUI)
        {   
            story.SetActive(true);
            // 페이드 인
            yield return StartCoroutine(Fade(story, fadeInTime, true));

            // 화면 표시 시간 기다림
            yield return new WaitForSeconds(displayTime);

            // 페이드 아웃
            yield return StartCoroutine(Fade(story, fadeOutTime, false));

            // 비활성화
            story.SetActive(false);
        }

        //프롤로그 재생 끝
        Managers.Game.changeScene(1);
    }

    private IEnumerator Fade(GameObject story, float fadeTime, bool fadeIn)
    {
        // 이미지나 텍스트 컴포넌트 가져오기
        Graphic graphic = story.GetComponent<Graphic>();

        // 시작 및 목표 알파값 설정
        float startAlpha = fadeIn ? 0 : 1;
        float targetAlpha = fadeIn ? 1 : 0;

        // 시간이 0일 경우, 즉시 알파값을 설정하고 끝냄
        if (fadeTime <= 0)
        {
            graphic.color = new Color(graphic.color.r, graphic.color.g, graphic.color.b, targetAlpha);
            yield break;
        }

        // 페이드 인/아웃 애니메이션
        float elapsedTime = 0;
        while (elapsedTime < fadeTime)
        {
            // 현재 알파값 계산
            float newAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeTime);
            // 알파값 적용
            graphic.color = new Color(graphic.color.r, graphic.color.g, graphic.color.b, newAlpha);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 최종 알파값 설정
        graphic.color = new Color(graphic.color.r, graphic.color.g, graphic.color.b, targetAlpha);
    }
}

using UnityEngine;
using System.Collections;

public class ScreenFade : MonoBehaviour
{
    public float fadeSpeed = 1.0f; // 페이드 속도를 조절합니다.
    public Transform fadeObject; // 검은 패널을 연결합니다.

    private void Start()
    {   
        // 시작 시 검은 패널의 알파값을 1로 설정하여 화면을 완전히 가립니다.
        fadeObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 1f);
    }

    // 페이드인 효과를 적용합니다.
    public void FadeIn()
    {
        StartCoroutine(Fade(1f, 0f));
    }

    // 페이드아웃 효과를 적용합니다.
    public void FadeOut()
    {
        StartCoroutine(Fade(0f, 1f));
    }

    // 검은 패널의 알파값을 변경하여 페이드 효과를 구현합니다.
    IEnumerator Fade(float startAlpha, float endAlpha)
    {
        float elapsedTime = 0f;
        Color startColor = fadeObject.GetComponent<Renderer>().material.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, endAlpha);

        while (elapsedTime < fadeSpeed)
        {
            fadeObject.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, elapsedTime / fadeSpeed);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        fadeObject.GetComponent<Renderer>().material.color = endColor;
    }
}

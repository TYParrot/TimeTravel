using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    public Button ExitButton;

    public TextMeshProUGUI Tel;

    public

    // 버튼을 누르기전에는 비활성화
    void Start()
    {
        ExitButton.gameObject.SetActive(false);
    }

    // 버튼을 누르고 조건이 맞으면 활성화
    public void TextViewButton()
    {
        string Text = Tel.text;
        if (Text.Length == 19)
        {
            ExitButton.gameObject.SetActive(true);
        }
    }
}

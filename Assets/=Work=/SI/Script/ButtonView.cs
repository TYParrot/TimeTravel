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

    // ��ư�� ������������ ��Ȱ��ȭ
    void Start()
    {
        ExitButton.gameObject.SetActive(false);
    }

    // ��ư�� ������ ������ ������ Ȱ��ȭ
    public void TextViewButton()
    {
        string Text = Tel.text;
        if (Text.Length == 19)
        {
            ExitButton.gameObject.SetActive(true);
        }
    }
}

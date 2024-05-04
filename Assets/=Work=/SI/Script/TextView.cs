using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextView : MonoBehaviour
{
    public TextMeshProUGUI Text;

    // 버튼을 누르기전에는 비활성화
    void Start()
    {
        Text.gameObject.SetActive(false);
    }

    // 버튼을 누르면 텍스트 활성화
    public void TextViewButton()
    {
        Text.gameObject.SetActive (true);
    }
}

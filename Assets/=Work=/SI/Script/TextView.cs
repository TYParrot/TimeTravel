using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextView : MonoBehaviour
{
    public TextMeshProUGUI Text;

    // ��ư�� ������������ ��Ȱ��ȭ
    void Start()
    {
        Text.gameObject.SetActive(false);
    }

    // ��ư�� ������ �ؽ�Ʈ Ȱ��ȭ
    public void TextViewButton()
    {
        Text.gameObject.SetActive (true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInput : MonoBehaviour
{
    public TextMeshProUGUI viewnum, viewmessage;
    
    public PlayQuickSound SoundScriptInstance;

    public TelephoneManager ManageScriptInstance;

    public UI_Telephone UiScriptInstance;

    public void Clicked0()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "0";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();



        }

    }

    public void Clicked1()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "1";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }

    }

    public void Clicked2()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "2";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }

    }
    public void Clicked3()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "3";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }

    }
    public void Clicked4()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "4";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ
        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }
    }
    public void Clicked5()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "5";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ
        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }

    }
    public void Clicked6()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "6";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }
    }
    public void Clicked7()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "7";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }
    }
    public void Clicked8()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "8";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }
    }
    public void Clicked9()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = "9";

        // ����
        viewnum.text = currentNum + additionalNum;

        //������ȣ�� �� �Է��ߴ��� üũ �ϰ� ����
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "ù ������ ������ȣ�� �����ؾ��� �Ȼ��� ���� ��ȣ�� '0345' ��";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "���� ��ȭ�ɰ� ���� ��ȣ�� �Է��غ�";
            }
        }
        // "-"�߰��ϰ� ����
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "���ϰ� �־�!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "������ ���п� �ٽ� ������ �� �ְ� �ƾ�!";

            Clear();

        }
    }
    //�Ҹ� ���
    public void SoundPlay()
    {
        string CurrentNum = viewnum.text;

        if(CurrentNum.Length == 19)
        {
            //���� ��ũ��Ʈ �Լ� ȣ��
            if (SoundScriptInstance != null)
            {
                SoundScriptInstance.Play();
            }
        }
    }

    //�� �Ŵ����� ����
    public void ExitButton()
    {
        if (ManageScriptInstance != null)
        {
            ManageScriptInstance.ClearGame();
        }
    }

    public void Clear()
    {
        if(UiScriptInstance != null)
        {
            UiScriptInstance.PlayAllClear();
        }
    }
}


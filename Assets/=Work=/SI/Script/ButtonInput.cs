using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInput : MonoBehaviour
{
    public TextMeshProUGUI viewnum, inputnum0, inputnum1, inputnum2, inputnum3, inputnum4, inputnum5, inputnum6, inputnum7, inputnum8, inputnum9, viewmessage;

    public void Clicked0()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum0.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }

    }

    public void Clicked1()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum1.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }

    }

    public void Clicked2()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum2.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }

    }
    public void Clicked3()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum3.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }

    }
    public void Clicked4()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum4.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }
    }
    public void Clicked5()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum5.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }

    }
    public void Clicked6()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum6.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }
    }
    public void Clicked7()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum7.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }
    }
    public void Clicked8()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum8.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }
    }
    public void Clicked9()
    {
        // ����
        string currentNum = viewnum.text;

        // �߰�
        string additionalNum = inputnum9.text;

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
            viewmessage.text = "���� ���п� �ٽ� ������ �� �ְ� �ƾ�!";
        }
    }
}
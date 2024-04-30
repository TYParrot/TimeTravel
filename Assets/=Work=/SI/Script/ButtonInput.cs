using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInput : MonoBehaviour
{
    public TextMeshProUGUI viewnum, inputnum0, inputnum1, inputnum2, inputnum3, inputnum4, inputnum5, inputnum6, inputnum7, inputnum8, inputnum9, viewmessage;

    public void Clicked0()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum0.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }

    }

    public void Clicked1()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum1.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }

    }

    public void Clicked2()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum2.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }

    }
    public void Clicked3()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum3.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }

    }
    public void Clicked4()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum4.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크
        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }
    }
    public void Clicked5()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum5.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크
        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }

    }
    public void Clicked6()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum6.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }
    }
    public void Clicked7()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum7.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }
    }
    public void Clicked8()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum8.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }
    }
    public void Clicked9()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = inputnum9.text;

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "retry";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "free";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "nice";
        }

        if (viewnum.text.Length == 19)
        {
            viewnum.text += "-";
            viewmessage.text = "congratulation";
        }
    }
}
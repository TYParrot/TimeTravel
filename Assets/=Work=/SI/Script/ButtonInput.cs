using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInput : MonoBehaviour
{
    public TextMeshProUGUI viewnum, viewmessage;
    
    public PlayQuickSound SoundScriptInstance;

    public TelephoneManager ManageScriptInstance;

    public void Clicked0()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "0";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";



        }

    }

    public void Clicked1()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "1";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }

    }

    public void Clicked2()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "2";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }

    }
    public void Clicked3()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "3";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }

    }
    public void Clicked4()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "4";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크
        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }
    }
    public void Clicked5()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "5";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크
        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }

    }
    public void Clicked6()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "6";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }
    }
    public void Clicked7()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "7";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }
    }
    public void Clicked8()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "8";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }
    }
    public void Clicked9()
    {
        // 현재
        string currentNum = viewnum.text;

        // 추가
        string additionalNum = "9";

        // 변경
        viewnum.text = currentNum + additionalNum;

        //지역번호를 잘 입력했는지 체크 하고 반응
        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 지역번호로 시작해야해 안산의 지역 번호는 '0345' 야";
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 전화걸고 싶은 번호를 입력해봐";
            }
        }
        // "-"추가하고 반응
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay();

            viewmessage.text = "고마워 덕분에 다시 움직일 수 있게 됐어!";

        }
    }
    //소리 재생
    public void SoundPlay()
    {
        string CurrentNum = viewnum.text;

        if(CurrentNum.Length == 19)
        {
            //사운드 스크립트 함수 호출
            if (SoundScriptInstance != null)
            {
                SoundScriptInstance.Play();
            }
        }
    }

    //씬 매니저에 접근
    public void ExitButton()
    {
        if (ManageScriptInstance != null)
        {
            ManageScriptInstance.ClearGame();
        }
    }
}


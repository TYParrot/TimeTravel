using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonInput : MonoBehaviour
{
    public TextMeshProUGUI viewnum, viewmessage;

    public AudioChange SoundScriptInstance;

    public TelephoneManager ManageScriptInstance;

    public UI_Telephone UiScriptInstance;

    public AudioChange AudioScriptInstance;

    public AudioClip clip, clip_clear, all_clear;

    public GameObject num_noBtn;
    public GameObject num_Btn;

    public void Clicked0()
    {
        if (viewnum.text.Length < 19)
        {
            

            string currentNum = viewnum.text;

            string additionalNum = "0";

            viewnum.text = currentNum + additionalNum;

        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }

        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }

    }

    public void Clicked1()
    {
        if (viewnum.text.Length < 19)
        {
            string currentNum = viewnum.text;

            string additionalNum = "1";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }

        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }

    }

    public void Clicked2()
    {
        if (viewnum.text.Length < 19)
        {
            string currentNum = viewnum.text;

            string additionalNum = "2";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }

    }
    public void Clicked3()
    {
        if (viewnum.text.Length < 19)
        {
            string currentNum = viewnum.text;

            string additionalNum = "3";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }

    }
    public void Clicked4()
    {
        if (viewnum.text.Length < 19)
        {
            string currentNum = viewnum.text;

            string additionalNum = "4";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }
    }
    public void Clicked5()
    {
        if (viewnum.text.Length < 19)
        {
            string currentNum = viewnum.text;

            string additionalNum = "5";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }

    }
    public void Clicked6()
    {
        if (viewnum.text.Length < 19)
        {

            string currentNum = viewnum.text;

            string additionalNum = "6";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }
    }
    public void Clicked7()
    {
        if (viewnum.text.Length < 19)
        {
            string currentNum = viewnum.text;

            string additionalNum = "7";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }
    }
    public void Clicked8()
    {
        if (viewnum.text.Length < 19)
        {
            string currentNum = viewnum.text;

            string additionalNum = "8";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }

        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }
    }
    public void Clicked9()
    {
        if (viewnum.text.Length < 19)
        {
            string currentNum = viewnum.text;

            string additionalNum = "9";

            viewnum.text = currentNum + additionalNum;

            
        }

        if (viewnum.text.Length == 9)
        {
            if (viewnum.text != "Tel: 0345")
            {
                viewnum.text = "Tel: ";
                viewmessage.text = "첫 시작은 안산의 \n지역번호로 시작해야해\n 안산의 지역번호는 '0345'야";
                Start();

                AudioPlay(clip, 1f);
            }
            else
            {
                viewnum.text += "-";
                viewmessage.text = "이제 아무 번호를\n입력해봐!\n안산산업역사 \n박물관으로\n연결될거야!";
                Start();
            }
        }
        if (viewnum.text.Length == 14)
        {
            viewnum.text += "-";
            viewmessage.text = "잘하고 있어!";
            Start();
        }

        if (viewnum.text.Length == 19)
        {
            SoundPlay(clip_clear, 50f);

            Clear();

        }
    }
    public void SoundPlay(AudioClip clip, float second)
    {
        string CurrentNum = viewnum.text;

        if (CurrentNum.Length == 19)
        {
            if (SoundScriptInstance != null)
            {
                SoundScriptInstance.PlayClip(clip, second);
            }
        }
    }

    public void ExitButton()
    {
        if (ManageScriptInstance != null)
        {
            ManageScriptInstance.ClearGame();
        }
    }

    public void Clear()
    {
        if (UiScriptInstance != null)
        {
            num_Btn.SetActive(false);
            num_noBtn.SetActive(true);
            AudioPlay(all_clear, 22f);
            StartCoroutine(afterAllClearAudio());
        }
    }

    void Start()
    {
        viewmessage.gameObject.SetActive(false);

        StartCoroutine(ActivateTMP());
    }

    IEnumerator ActivateTMP()
    {
        viewmessage.gameObject.SetActive(true);

        yield return new WaitForSeconds(3f);

        viewmessage.gameObject.SetActive(false);
    }

    public void AudioPlay(AudioClip clip, float second)
    {
        if (AudioScriptInstance != null)
        {
            AudioScriptInstance.PlayClip(clip, second);
        }
    }

    IEnumerator afterAllClearAudio(){
        yield return new WaitForSeconds(22f);
        UiScriptInstance.PlayAllClear();
    }
}
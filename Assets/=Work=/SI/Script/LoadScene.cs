using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    //전달받은 데이터를 저장할 변수
    public string ReceiveData;

    //씬 전환시 호출
    void Awake()
    {
        //전달된 데이터 받기
        ReceiveData = SceneManager.GetActiveScene().name;
    }
}

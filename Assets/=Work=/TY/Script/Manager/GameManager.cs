using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

namespace Game
{
    //여기서 클리어 된 게임들을 체크할 것
    //GameManager는 하나밖에 존재하지 못함
    //게임이 클리어 되었을 시 ex) Managers.Game.ClearRadio(true); Manageres.Game.changeScene(1); 호출하면 클리어로 업데이트
    //씬 업데이트도 Managers.Game.changeScene(index); 로 접근
    //클리어 메소드에 interaction을 막는 코드 추가해야함. 이것도 Init할 때 초기화해주기.
    //각 씬의 Manager가 있다면 Start될 때, Managers.Game.SceneSetting() 호출 필요.

    public class GameManager
    {
        //startPoint는 게임이 끝나고 start 화면 전환시 사용
        //HousePoint는 start 화면에서 House 씬으로 전환시 사용
        public GameObject startPoint;
        public GameObject housePoint;
        private bool RadioCheck;
        private bool MicrowaveCheck;
        private bool TelePhoneCheck;
        private int currentIndex;
        private int beforeIndex;
        private GameObject ClearList;

        //씬 전환 전 플레이어 위치와 회전값 저장
        private GameObject player;
        private Vector3 playerPos;
        private Vector3 playerRot;


        //게임 재실행 시 reset 용도
        public void Init(){
            RadioCheck = false;
            MicrowaveCheck = false;
            TelePhoneCheck = false;


            Managers.Game.FindPlayer();
            Managers.Scenario.Init();
            Managers.Game.StartPlayerSetting();
        }

        public void changeScene(int index){

            beforeIndex = SceneManager.GetActiveScene().buildIndex;
            currentIndex = index;

            //플레이어 위치 저장은 씬 전환 전 일어나야함.
            if(index > 1){
                SavePlayer();
            }

            SceneManager.LoadScene(index);
        }

        public void SceneSetting(){
            switch (currentIndex)
            {
                case 0:
                    Managers.Game.Init();
                    break;
                case 1:
                    Managers.Game.FindPlayer();
                    Managers.Game.LoadPlayer();
                    Managers.Game.ShowClearList();
                    break;
                case 2:
                    Managers.Game.FindPlayer();
                    break;
                case 3:
                    Managers.Game.FindPlayer();
                    break;
                case 4:
                    Managers.Game.FindPlayer();
                    break;
            }
        }

        public int CurrentIndex(){
            return currentIndex;
        }

        public void ClearRadio(bool clear){
            if(clear){
                RadioCheck = true;
            }
        }

        public void ClearMicrowave(bool clear){
            if(clear){
                MicrowaveCheck = true;
            }
        }

        public void ClearTelephone(bool clear){
            if(clear){
                TelePhoneCheck = true;
            }
        }

        //시나리오에서 확인용도
        public bool ReturnRadio(){
            return RadioCheck;
        }

        public bool ReturnMicrowave(){
            return MicrowaveCheck;
        }        
        
        public bool ReturnTelephone(){
            return TelePhoneCheck;
        }

        private void ShowClearList(){
            ClearList = GameObject.Find("GameList");
            
            if(MicrowaveCheck)  ClearList.GetComponent<UI_GameList>().ActiveMicrowave();
            if(RadioCheck)  ClearList.GetComponent<UI_GameList>().ActiveRadio();
            if(TelePhoneCheck)  ClearList.GetComponent<UI_GameList>().ActiveTelephone();

            ClearList.SetActive(true);
        }
        
        private void SavePlayer(){
            playerPos = player.transform.position;
            playerRot  = player.transform.rotation.eulerAngles;
        }

        private void LoadPlayer(){
            if(beforeIndex == 5){
                HousePlayerSetting();
                Debug.Log("houseplayersetting 호출 완료");
            }else{
                player.transform.position = playerPos;
                player.transform.rotation = Quaternion.Euler(playerRot);
                Debug.Log("플레이어 로드 완료");
            }
        }

        //StartPoint 지정하기
        private void StartPlayerSetting(){
            if(startPoint == null){
                startPoint = GameObject.Find("StartPoint");
            }
            player.transform.position = startPoint.transform.position;
            player.transform.rotation = Quaternion.Euler(startPoint.transform.rotation.eulerAngles);
            Debug.Log("스타트 포인트 세팅 완료");
        }

        private void HousePlayerSetting(){
            if(housePoint == null){
                housePoint = GameObject.Find("HousePoint");
            }
            player.transform.position = housePoint.transform.position;
            player.transform.rotation = Quaternion.Euler(housePoint.transform.rotation.eulerAngles);
            Debug.Log("하우스 포인트 세팅 완료");
        }

        private void FindPlayer(){
            //시뮬레이터를 player로 설정해놨음. 추후에 변경해야함.
            player = GameObject.Find("XR Origin (XR Rig)");
            Debug.Log("플레이어 확인");
        }

    }
}
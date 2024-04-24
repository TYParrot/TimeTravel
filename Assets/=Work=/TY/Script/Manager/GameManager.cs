using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    //여기서 클리어 된 게임들을 체크할 것
    //GameManager는 하나밖에 존재하지 못함
    //게임이 클리어 되었을 시 ex) Managers.Game.ClearRadio(true); 호출하면 클리어로 업데이트
    //씬 업데이트도 Managers.Game.changeScene(index); 로 접근
    //클리어 메소드에 interaction을 막는 코드 추가해야함. 이것도 Init할 때 초기화해주기.
    //게임이 끝나고 start 씬으로 로드 될 때, clearList에 대한 접근이 불가능해지므로, 참고해서 수정해야함.

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

            //시뮬레이터를 player로 설정해놨음. 추후에 변경해야함.
            player = GameObject.Find("XR Origin (XR Rig)");
        }

        public void changeScene(int index){

            beforeIndex = SceneManager.GetActiveScene().buildIndex;

            //플레이어 위치 저장은 씬 전환 전 일어나야함.
            if(index > 1){
                SavePlayer();
            }

            SceneManager.LoadScene(index);
            currentIndex = SceneManager.GetActiveScene().buildIndex;

            //Player 세팅은 씬 전환 후 일어나야함.
            //게임 재시작시에만 실행되는 부분
            if(beforeIndex == 0 && currentIndex == 1){
                Managers.Scenario.Init();
            }

            switch (currentIndex)
            {   
                //0으로 전환 == Start 씬으로 돌아감. 초기화 필요
                case 0:
                    Managers.Scenario.Init();
                    Managers.Game.Init();
                    Managers.Game.StartPlayerSetting();
                    break;
                case 1:
                    Managers.Game.LoadPlayer();
                    Managers.Game.ShowClearList();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
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
            if(beforeIndex == 0){
                HousePlayerSetting();
            }else{
                player.transform.position = playerPos;
                player.transform.rotation = Quaternion.Euler(playerRot);
            }
        }

        //StartPoint 지정하기
        private void StartPlayerSetting(){
            if(startPoint == null){
                GameObject.Find("StartPoint");
            }
            player.transform.position = startPoint.transform.position;
            player.transform.rotation = Quaternion.Euler(startPoint.transform.rotation.eulerAngles);
        }

        private void HousePlayerSetting(){
            if(housePoint == null){
                GameObject.Find("HousePoint");
            }
            player.transform.position = housePoint.transform.position;
            player.transform.rotation = Quaternion.Euler(housePoint.transform.rotation.eulerAngles);
        }

    }
}
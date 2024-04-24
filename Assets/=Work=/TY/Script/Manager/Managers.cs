using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;
using Game.Helpers;
using Unity.VisualScripting;

//Managers에서 GameManager로 접근해야함. 
//추후 oculus 연결 시에 xrSimulator 없애기.
//현재 Start씬에 xr을 놓은 상태라 추후에 0으로 씬전환시 오디오 중복 문제 있음.
//Managers에서 Start시에 Player 없으면 Oculus 프리팹 Player이름으로 생성되도록 하는 방식으로 변경해야함.
public class Managers : Game.Helpers.Singleton<Managers>
{
    private GameManager _game = new();
    private ScenarioManager _scenario = new();
    public static GameManager Game => Instance._game;
    public static ScenarioManager Scenario => Instance._scenario;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;
using Game.Helpers;
using Unity.VisualScripting;
using UnityEngine.XR;

public class Managers : Game.Helpers.Singleton<Managers>
{
    private GameManager _game = new();
    private ScenarioManager _scenario = new();
    public static GameManager Game => Instance._game;
    public static ScenarioManager Scenario => Instance._scenario;

    void Start()
    {
        DontDestroyOnLoad(this);

    }

}

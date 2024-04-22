using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBtn : MonoBehaviour
{
    public void Btn(){
        Managers.Game.ClearRadio(true);
    }
}

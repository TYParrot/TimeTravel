using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelephoneScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToTelephone(){
        Managers.Game.changeScene(3);        
    }

}

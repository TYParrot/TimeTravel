using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public InputActionAsset inputActionAsset;
    public Text textUI1;
    public Text textUI2;
    public Text textUI3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hmdPosition = inputActionAsset.actionMaps[0].actions[0].ReadValue<Vector3>();
        Vector3 rightPosition = inputActionAsset.actionMaps[4].actions[0].ReadValue<Vector3>();
        Vector3 leftPosition = inputActionAsset.actionMaps[2].actions[0].ReadValue<Vector3>();


        textUI1.text = "HeadSet Position : "+(hmdPosition.ToString());
        textUI2.text = "Right Position : "+(rightPosition.ToString());
        textUI3.text = "Left Position : "+(leftPosition.ToString());

    }
}

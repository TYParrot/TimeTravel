using UnityEngine;
using UnityEngine.UI;

public class PopUpController : MonoBehaviour
{

    public GameObject fistpopup;

    void Start()
    {
       fistpopup.SetActive(true);
    }

    public void ClosePopUp(){
        fistpopup.SetActive(false);
    }
}


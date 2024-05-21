using UnityEngine;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour
{
    public Slider slider; 
    public GameObject lastPopup;

    private bool gaugeFull = false; 

    void Start()
    {
      
        slider.onValueChanged.AddListener(GaugeChanged);
    }

    public void GaugeChanged(float value)
    {
      
        if (slider.fillRect.anchorMax.x >= 1f)
        {
            gaugeFull = true;
        }
        else
        {
            gaugeFull = false;
        }

        if (gaugeFull && !lastPopup.activeSelf)
        {
            lastPopup.SetActive(true);
        }
    }
}

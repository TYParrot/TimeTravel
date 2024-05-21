using UnityEngine;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour
{
    public Slider slider; 
    private UI_Micro ui;

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

        if (gaugeFull)
        {
            Managers.Game.ClearMicrowave(true);
            ui.PlayAllClear();
        }
    }
}

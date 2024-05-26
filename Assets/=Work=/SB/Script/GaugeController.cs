using UnityEngine;
using UnityEngine.UI;

public class GaugeController : MonoBehaviour
{
    public Slider slider; 

    public UI_Micro ui;

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
            ui.PlayAllClear();
            Managers.Game.ClearMicrowave(true);
        }
    }

    public bool returnGaugeFull(){
        return gaugeFull;
    }
}

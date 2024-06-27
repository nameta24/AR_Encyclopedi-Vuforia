using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggle : MonoBehaviour
{

    bool inOn = false;
    [SerializeField] GameObject TogglePanelInfo;

    public void InfoPanel()
    {
        if (inOn)
        {
            TogglePanelInfo.SetActive(false);
            inOn = false;
        }
        else
        {
            TogglePanelInfo.SetActive(true);
            inOn =true;
        }
    }
}

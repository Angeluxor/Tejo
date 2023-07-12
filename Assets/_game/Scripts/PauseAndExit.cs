using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseAndExit : MonoBehaviour
{
    public GameObject panel;

    public void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (panel.activeSelf)
            {
                Continuar();
                panel.SetActive(false);
            }
            else
            {
                Pausar();
                panel.SetActive(true);
            }
        }
       
       
       
    }
    public void Pausar()
    {
        Time.timeScale = 0;
    }

    public void Continuar()
    {
        Time.timeScale = 1;
    }

  
}

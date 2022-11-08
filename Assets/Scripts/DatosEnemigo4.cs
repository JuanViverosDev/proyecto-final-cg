using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosEnemigo4 : MonoBehaviour
{
    public int vidaEnemigo4=10;
    public Slider barraVidaE4;
    public int damage=2;
    
    void Update()
    {
        barraVidaE4.value = vidaEnemigo4;

        if(Input.GetKeyDown(KeyCode.X))
        {
            vidaEnemigo4 -= damage;
        }
    }
}

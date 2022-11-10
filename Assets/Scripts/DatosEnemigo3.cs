using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosEnemigo3 : MonoBehaviour
{
    public int vidaEnemigo3=10;
    public Slider barraVidaE3;
    public int damage=2;
    
    void Update()
    {
        barraVidaE3.value = vidaEnemigo3;

        if(Input.GetKeyDown(KeyCode.X))
        {
            vidaEnemigo3 -= damage;
        }
    }
}

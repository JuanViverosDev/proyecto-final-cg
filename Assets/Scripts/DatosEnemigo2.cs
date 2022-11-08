using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosEnemigo2 : MonoBehaviour
{
    public int vidaEnemigo2=10;
    public Slider barraVidaE2;
    public int damage=2;
    
    void Update()
    {
        barraVidaE2.value = vidaEnemigo2;

        if(Input.GetKeyDown(KeyCode.X))
        {
            vidaEnemigo2 -= damage;
        }
    }
}

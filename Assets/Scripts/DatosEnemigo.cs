using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatosEnemigo : MonoBehaviour
{
    public int vidaEnemigo1=10;
    public Slider barraVidaE1;
    public int damage=2;

    void Update()
    {
        barraVidaE1.value = vidaEnemigo1;

        if(Input.GetKeyDown(KeyCode.X))
        {
            vidaEnemigo1 -= damage;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosJugador : MonoBehaviour
{
    public int vidaJugador;
    // Update is called once per frame
    void Update()
    {
        if (vidaJugador < 1){
            Debug.Log("Game Over");
        }
    }
}

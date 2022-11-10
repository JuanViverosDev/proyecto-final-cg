using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaGolpes : MonoBehaviour
{
    public bool golpe=false;
    public Rigidbody rJugador;

    void Update()
    {
        if(golpe)
        {
            rJugador.AddForce(new Vector3(0,1,50),ForceMode.Impulse);
        }
    }
}

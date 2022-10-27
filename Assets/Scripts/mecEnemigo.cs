using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mecEnemigo : MonoBehaviour
{
    public float rangoAlerta;
    public LayerMask capaJugador;
    bool estarAlerta;
    public Transform jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position,rangoAlerta, capaJugador);

        if(estarAlerta==true){
            transform.LookAt(jugador);
        }

    }

    private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position,rangoAlerta);
    }

}

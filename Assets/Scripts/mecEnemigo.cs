using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mecEnemigo : MonoBehaviour
{
    public float rangoAlerta;
    public LayerMask capaJugador;
    bool estarAlerta;
    public Transform jugador;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position,rangoAlerta, 
        capaJugador);

        if(estarAlerta==true){
            
             transform.LookAt(new Vector3(jugador.position.x,
             transform.position.y,jugador.position.z));
             transform.position = Vector3.MoveTowards(transform.position,
             new Vector3(jugador.position.x,transform.position.y,
             jugador.position.z), velocidad*Time.deltaTime);

        }

    }

    private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position,rangoAlerta);
    }

}

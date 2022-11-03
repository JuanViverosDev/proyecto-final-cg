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
    bool atacar; 
    public float rangoAtaque;
    public Animator a;

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

        atacar = Physics.CheckSphere(transform.position,rangoAtaque, 
        capaJugador);

        if(atacar){           
            a.SetBool("atacar", true);

        }else{
             a.SetBool("atacar", false);
        } 
        
        if(atacar && Input.GetKeyDown(KeyCode.X)){
            a.SetBool("damage", true);
            Debug.Log("funciona");
        }
        else{
           
            a.SetBool("damage", false);
        }
    


    }



    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,rangoAlerta);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,rangoAtaque);
        
    }

}

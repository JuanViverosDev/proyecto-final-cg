using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public Jugador logicaP1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other){
        logicaP1.saltar = true;
    }

    private void OnTriggerExit(Collider other){
        logicaP1.saltar = false;
    }

}

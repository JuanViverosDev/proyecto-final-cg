using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCm : MonoBehaviour
{
    public GameObject main, cam;
    public bool estado;
    void Start()
    {
        estado = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(estado){
            if (Input.GetKey(KeyCode.C))
            {
                cam.SetActive(true);
                main.SetActive(false);
            }
            else
            {
                cam.SetActive(false);
                main.SetActive(true);
            }
        }
        

    }
}

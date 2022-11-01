using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsV : MonoBehaviour
{
    public GameObject vistas;
    public int i = 1;
    public changeCm e;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (i > 3){
                e.estado = false;
                return;
            }

            vistas.transform.Find($"v{i}F").gameObject.SetActive(true);
            vistas.transform.Find($"v{i}T").gameObject.SetActive(false);
            i++;                
        }

    }
}

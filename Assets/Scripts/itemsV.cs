using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsV : MonoBehaviour
{
    public GameObject vistas;
    public int i;
    public changeCm e;
    void Start()
    {
        i = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (i < 4)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                vistas.transform.Find($"v{i}F").gameObject.SetActive(true);
                vistas.transform.Find($"v{i}T").gameObject.SetActive(false);
                i++;
            }
        }
        else
        {
            if (!Input.GetKey(KeyCode.C))
            {
                e.estado = false;
                return;
            }
        }
    }
}

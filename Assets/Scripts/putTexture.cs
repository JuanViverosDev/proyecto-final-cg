using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putTexture : MonoBehaviour
{
    public Material txt;
    void Start()
    {
        
    }

    private void OnValidate()
    {
        cambiarTex(transform.gameObject);
    }
    void Update()
    {
    }

    public void cambiarTex(GameObject obj)
    {
        int p = obj.transform.childCount;
        if (p != 0)
        {
            for (int i = 0; i < p; i++)
            {
                cambiarTex(obj.transform.GetChild(i).gameObject);

            }
        }
        else
        {
            Renderer a = obj.GetComponent<Renderer>();
            if (a != null)
            {
                a.material = txt;
            }
        }
        
    }
}

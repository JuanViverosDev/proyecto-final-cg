using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColAir : MonoBehaviour
{
    public changeCm scriptCam;
    public GameObject obj;
    public Material original, temp;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptCam.estado && Input.GetKey(KeyCode.C))
        {
            putTexture.cambiarTex(obj, temp);
        }
        else
        {
            putTexture.cambiarTex(obj, original);
        }
    }
}

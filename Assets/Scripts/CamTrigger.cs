using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public Transform pRef;
    private Transform pBack;
    private bool estado = true;// Start is called before the first frame update

    private void Start()
    {
        pBack = transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (estado)
        {
            transform.RotateAround(pRef.position, Vector3.up, 180);
            estado = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.rotation = pBack.rotation;
        estado = true;
    }
}

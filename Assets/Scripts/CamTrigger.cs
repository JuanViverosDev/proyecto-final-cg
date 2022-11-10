using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour
{
    public Transform pRef;
    public GameObject pCam;
    private Transform pBack;
    private bool estado = true;// Start is called before the first frame update

    private void Start()
    {
        pBack = pCam.transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (estado && !other.CompareTag("Player"))
        {
            Debug.Log("entro");
            pCam.transform.position = new Vector3(pRef.position.x, pCam.transform.position.y, pRef.position.z);
            estado = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (estado && !other.CompareTag("Player"))
        {
            Debug.Log("salio");
            pCam.transform.position = pBack.position;
            estado = true;
        }
    }
}

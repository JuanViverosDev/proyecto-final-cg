using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollidersP : MonoBehaviour
{
    // Start is called before the first frame update
    private int i = 0;
    public Text pocion;
    public bool checkP = false;
    public Transform respawn, respawn2;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pocion"))
        {
            other.gameObject.SetActive(false);
            i += 1;
            pocion.text = "" + i;
        }
        if (other.CompareTag("Abismo"))
        {
            if (checkP)
            {
                transform.position = respawn2.position;
            }
            else
            {
                transform.position = respawn.position;
            }
        }
        if (other.CompareTag("CheckP"))
        {
            checkP = true;
        }
    }
}

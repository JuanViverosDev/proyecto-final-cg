using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect_Letter : MonoBehaviour
{ 
    public string frase;
    public Text dialogo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in frase)
        {
            dialogo.text = dialogo.text + caracter;
            yield return new WaitForSeconds(0.06f);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargarPuntajeT : MonoBehaviour
{
    public Effect_LetterN terra, ignis, aqua, ventus, score;
    public DatosJugador datos;
    void Awake()
    {
        terra.frase = ""+ datos.scores1;
        ignis.frase = "" + datos.scores2;
        aqua.frase = "" + datos.scores3;
        ventus.frase = "" + datos.scores4;
        int scoreTotal = datos.scores1 + datos.scores2 + datos.scores3 + datos.scores4;
        score.frase = "" + scoreTotal;
    }

}

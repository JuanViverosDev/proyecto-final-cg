using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargarPuntajeN : MonoBehaviour
{
    public int escena;
    public Effect_LetterN tiempo, tiempoP, corazonesP, scoreP;
    public vidaManagerCanvas i;
    public DatosJugador datos;
    void Awake()
    {
        if(escena == 1)
        {
            tiempo.frase = TimeFormat(datos.tiempo1);
            tiempoP.frase = "" + puntajeTiempo(datos.tiempo1);
            corazonesP.frase = "" + puntajeVida(datos.vida1);
            scoreP.frase = "" + datos.scores1;
            i.vida = datos.vida1;
            
        }
        if (escena == 2)
        {
            tiempo.frase = TimeFormat(datos.tiempo2);
            tiempoP.frase = "" + puntajeTiempo(datos.tiempo2);
            corazonesP.frase = "" + puntajeVida(datos.vida2);
            scoreP.frase = "" + datos.scores2;
            i.vida = datos.vida2;
        }
        if (escena == 3)
        {
            tiempo.frase = TimeFormat(datos.tiempo3);
            tiempoP.frase = "" + puntajeTiempo(datos.tiempo3);
            corazonesP.frase = "" + puntajeVida(datos.vida3);
            scoreP.frase = "" + datos.scores3;
            i.vida = datos.vida3;
        }
        if (escena == 4)
        {
            tiempo.frase = TimeFormat(datos.tiempo4);
            tiempoP.frase = "" + puntajeTiempo(datos.tiempo4);
            corazonesP.frase = "" + puntajeVida(datos.vida4);
            scoreP.frase = "" + datos.scores4;
            i.vida = datos.vida4;
        }
    }


    public int puntajeVida(int vida)
    {
        if (vida == 0)
            return 300;
        else
        {
            if (vida == 1)
                return 200;
            else
                return 100;
        }
    }


    public int puntajeTiempo(int tiempo)
    {
        if (tiempo < 301)
        {
            if (tiempo < 100)
                return 102000;
            if (tiempo < 200)
                return 101000;
            return 100000;
        }

        else
        {
            int valor = 100000 - tiempo;
            if (valor < 0)
                return 0;
            return valor;
        }

    }

    public string TimeFormat(int s)
    {
        int hora = (int)(s / 3600);
        int minuto = (int)((s - (hora * 3600)) / 60);
        int segundo = s - (hora * 3600) - (minuto * 60);

        string thora = hora < 10 ? "0" + hora : "" + hora;
        string tmin = minuto < 10 ? "0" + minuto : "" + minuto;
        string tseg = segundo < 10 ? "0" + segundo : "" + segundo;

        return thora + ":" + tmin + ":" + tseg;

    }
}

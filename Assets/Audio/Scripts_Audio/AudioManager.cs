using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sonido[] sonidos;
    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else{
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sonido s in sonidos)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start(){
        Play("Instrumental");
    }

    public void Play(string nombre)
    {
        Sonido s = Array.Find(sonidos, sonido => sonido.nombre == nombre);
        if (s == null)
        {
            Debug.LogWarning("Falta Sonido:" + nombre + "No se encuentra!");
            return;
        }
        s.source.Play();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPerdida : MonoBehaviour
{
    public GameObject capsula;
    public AudioSource audioAmbiente;
    public AudioSource audioPerder;

    private bool perdida = false;

    void Update()
    {
        if (!perdida && capsula.transform.position.y < 1f)
        {
            perdida = true;

            audioAmbiente.Stop(); // Detiene la música
            audioPerder.Play();   // Reproduce el sonido de perder

            Debug.Log("Perdiste");
        }
    }
}
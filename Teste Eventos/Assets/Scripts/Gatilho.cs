using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatilho : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj)
    {
        Eventos.current.Perto();
    }

    private void OnTriggerExit(Collider obj)
    {
        Eventos.current.Longe();
    }
}
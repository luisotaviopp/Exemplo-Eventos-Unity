using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    void Start()
    {
        Eventos.current.chegouPertoPorta += AbrePorta;
        Eventos.current.afastouPorta += FechaPorta;
    }

    private void AbrePorta()
    {
        Debug.Log("Abre Porta");
        transform.Translate(new Vector3(0, 10f, 0), Space.World);
    }

    private void FechaPorta()
    {
        Debug.Log("Fecha Porta");
        transform.Translate(new Vector3(0, -10, 0), Space.World);
    }
}

// Usei o código desse vídeo como referência.
// https://www.youtube.com/watch?v=gx0Lt4tCDE0
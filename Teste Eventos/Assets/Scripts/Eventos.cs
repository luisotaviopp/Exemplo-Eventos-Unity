using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventos : MonoBehaviour
{
    // Prepara o singleton, isso faz com que só exista uma classe Eventos.
    public static Eventos current;
    private void Awake()
    {
        current = this;
    }



    // Disparado quando o jogador chega perto da porta.
    public event Action chegouPertoPorta;

    public void Perto()
    {
        if (chegouPertoPorta != null)
        {
            chegouPertoPorta();
        }
    }


    // Disparado quando o jogador se afasta da porta.
    public event Action afastouPorta;

    public void Longe()
    {
        if (afastouPorta != null)
        {
            afastouPorta();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip Rap,Seum,cap4,vinil,toda,kille,hear,Datena;
    public float NumeroMusicas;
    public bool PausePlay;

    // Start is called before the first frame update
    void Start()
    {
        PausePlay = true;
        NumeroMusicas = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if(!audio.isPlaying)
        {
            if (PausePlay)
            {
                audio.Play();
            }
            
        }
        else
        {
            if (!PausePlay)
            {
                audio.Pause();
            }
            if (NumeroMusicas == 0)
            {
             
                 audio.clip = Seum;              
            }

            else if (NumeroMusicas == 1)
            {
                audio.clip = Rap;
            }

            else if (NumeroMusicas == 2)
            {
                audio.clip = cap4;
            }
            else if (NumeroMusicas == 3)
            {
                audio.clip = vinil;
            }
            else if (NumeroMusicas == 4)
            {
                audio.clip = toda;
            }
            else if (NumeroMusicas == 5)
            {
                audio.clip = kille;
            }
            else if (NumeroMusicas == 6)
            {
                audio.clip = hear;
            }

            else if (NumeroMusicas == 7)
            {
                audio.clip = Datena;
            }
        }

        if (NumeroMusicas < 0)
        {
            NumeroMusicas = 7;
        }
        else if(NumeroMusicas > 7)
        {
            NumeroMusicas = 0;
        }


    }

     public void AvancaMusica()
     {
        NumeroMusicas++;
     }

    public void VoltaMusica()
     {
        NumeroMusicas--;
     }

    public void PauseAndPlay()
    {
        PausePlay = !PausePlay;

    }
}

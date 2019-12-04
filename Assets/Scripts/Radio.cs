using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip Rap,Seum;
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
        }

        if (NumeroMusicas < 0)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public static Radio instancia=null;
    public AudioSource audioS;
    public AudioClip Rap,Seum,cap4,vinil,toda,kille,hear,Datena;
    public float NumeroMusicas;
    public bool PausePlay;


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        PausePlay = true;
        NumeroMusicas = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if(!audioS.isPlaying)
        {
            if (PausePlay)
            {
                audioS.Play();
            }
            
        }
        else
        {
            if (!PausePlay)
            {
                audioS.Pause();
            }
            if (NumeroMusicas == 0)
            {
             
                 audioS.clip = Seum;              
            }

            else if (NumeroMusicas == 1)
            {
                audioS.clip = Rap;
            }

            else if (NumeroMusicas == 2)
            {
                audioS.clip = cap4;
            }
            else if (NumeroMusicas == 3)
            {
                audioS.clip = vinil;
            }
            else if (NumeroMusicas == 4)
            {
                audioS.clip = toda;
            }
            else if (NumeroMusicas == 5)
            {
                audioS.clip = kille;
            }
            else if (NumeroMusicas == 6)
            {
                audioS.clip = hear;
            }

            else if (NumeroMusicas == 7)
            {
                audioS.clip = Datena;
            }
        }

        if (NumeroMusicas < 0)
        {
            NumeroMusicas = 0;
        }
        else if (NumeroMusicas > 7)
        {
            NumeroMusicas = 7;
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

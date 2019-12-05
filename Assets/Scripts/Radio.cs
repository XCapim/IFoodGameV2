using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    public static Radio instancia=null;
    public AudioSource audioS;
    public AudioClip[] Musicas;
    public Animator anim;
    public bool PausePlay,anima;


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
       
    }

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        PausePlay = true;
        audioS.clip = Musicas[4];
        anima = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!audioS.isPlaying)
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
        }

        if (anima == false)
        {
            anim.SetBool("Pausa", false);
        }
        else if (anima)
        {
            anim.SetBool("Pausa", true);
        }


    }

     public void AvancaMusica()
     {

      audioS.clip= Musicas[Random.Range(0, 7)];
     }

    public void VoltaMusica()
     {
     
        audioS.clip = Musicas[Random.Range(0, 7)];
    }

    public void PauseAndPlay()
    {
        PausePlay = !PausePlay;
        anima = !anima;

    
    }
}

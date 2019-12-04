using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public static Radio instancia=null;
    public AudioSource audioS;
    public AudioClip[] Musicas; 
    public bool PausePlay;


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

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
   
    public AudioSource audioSSS;
    public AudioClip morto;
    public Animator anim;
    public Collider2D Npc;
    public Text PerdendoDolla;
    public GameObject PerdeDollar;
    public bool ativa;
    float tempo;

    void Start()
    {
        ativa = false;
        PerdeDollar.SetActive(false);
        tempo = 0f;
    }

    void Update()
    {
 
        anim.SetBool("Andando", true);
        
        if (ativa)
        {
            tempo += Time.deltaTime;  
        }

        if (tempo >= 2f)
        {
            PerdeDollar.SetActive(false);      
            Destroy(this.gameObject);
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            PerdePremios();      
        }
        else if (collision.gameObject.CompareTag("pizza"))
        {      
         
            PerdePremios();
         
        }
    }


    void attText()
    {
       
        PerdendoDolla.text = "-$ " + GameController.instancia.AtualPerdePremio.ToString();
    }

     void PerdePremios()
    {
        anim.SetBool("Morto", true);
        Npc.enabled = false;
        audioSSS.clip = morto;
        audioSSS.Play();
        GameController.instancia.Atropelados++;
        PerdeDollar.SetActive(true);
        GameController.instancia.AtualPerdePremio = GameController.instancia.PerdePremio[Random.Range(0, 4)];
        GameController.instancia.Dineiro -= GameController.instancia.AtualPerdePremio;
        SmartPhoneController.instancia.tempo -= 5f;
        ativa = true;
        attText();
    }
}

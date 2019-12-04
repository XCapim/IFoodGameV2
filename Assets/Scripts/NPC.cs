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
    bool quant,ativa;
    float tempo;

    // Start is called before the first frame update
    void Start()
    {
        quant = true;
        ativa = false;
        PerdeDollar.SetActive(false);
        tempo = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (quant)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.005f, 0);
            anim.SetBool("Andando", true);
        }


        if (ativa)
        {
            tempo += Time.deltaTime;
        }

        if (tempo >= 2f)
        {
            PerdeDollar.SetActive(false);
            ativa = false;
            tempo = 0;
        }

        attText();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            quant =false;
            anim.SetBool("Morto", true);
            Npc.enabled = false;
            audioSSS.clip = morto;
            audioSSS.Play();
            GameController.instancia.Atropelados++;
            PerdeDollar.SetActive(true);
            GameController.instancia.AtualPerdePremio = GameController.instancia.PerdePremio[Random.Range(0, 4)];
            GameController.instancia.Dineiro -= GameController.instancia.AtualPerdePremio;
            ativa = true;
        }
        else if (collision.gameObject.CompareTag("pizza"))
        {
            quant = false;
            anim.SetBool("Morto", true);
            Npc.enabled = false;
            audioSSS.clip = morto;
            audioSSS.Play();
            GameController.instancia.Atropelados++;
            PerdeDollar.SetActive(true);
            GameController.instancia.AtualPerdePremio=GameController.instancia.PerdePremio[Random.Range(0, 4)];
            GameController.instancia.Dineiro -= GameController.instancia.AtualPerdePremio;
            ativa = true;

        }
    }


    void attText()
    {
        PerdendoDolla.text = "-$ " + GameController.instancia.AtualPerdePremio.ToString();
    }
}

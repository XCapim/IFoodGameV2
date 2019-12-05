using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missao1 : MonoBehaviour
{


    public GameObject pizza;
    public Animator anima;
    public bool liga,ContaCollider,andando,morto,ativa;
    public AudioSource audioM;
    public AudioClip ThankYou,mortu;
    public CircleCollider2D missaum;
    public BoxCollider2D colli;
    float tempo;

    // Start is called before the first frame update
    void Start()
    {
        colli.enabled = true;
        pizza.SetActive(true);
        morto = false;
        liga = false;
        ativa = false;
        missaum.enabled = true;
        ContaCollider = false;
        anima.SetBool("morto", false);
    }

    // Update is called once per frame
    void Update()
    {

        if (ativa)
        {
            tempo += Time.deltaTime;
        }

        if (tempo >= 3f)
        {
       
            Destroy(this.gameObject);
        }

        if (liga)
        {
        
            GanhandoMoney.instancia.Dollar.SetActive(true);  
            GanhandoMoney.instancia.ativaTempo = true;
            tempo += Time.deltaTime;
        }

        if (tempo >= 1f)
        {
            Destroy(this.gameObject);
        }

        if (ContaCollider && !morto)
        {
            missaum.enabled = false;
            audioM.clip = ThankYou;
            audioM.Play();
            liga = true;
            GameController.instancia.AtualPremio = GameController.instancia.Premios[Random.Range(0, 5)];
            GameController.instancia.Dineiro += GameController.instancia.AtualPremio;
            GanhandoMoney.instancia.Tocar = true;
            GameController.instancia.QuantidadeDeEntregas++;
            SmartPhoneController.instancia.tempo += 3f;
            ContaCollider = false;
            
        }

        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pizza") && GameController.instancia.Missao1Ativo)
        {
            ContaCollider = true;      
                      
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            colli.enabled = false;
            anima.SetBool("morto", true);
            morto = true;
            GameController.instancia.Atropelados++;
            ativa = true;
            audioM.clip = mortu;
            audioM.Play();
            SmartPhoneController.instancia.tempo -= 8f;
            pizza.SetActive(false);
            
        }
    }




}

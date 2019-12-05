using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missao1 : MonoBehaviour
{
   

  

    public bool liga,ContaCollider,andando;
    public AudioSource audioM;
    public AudioClip ThankYou;
    public CircleCollider2D missaum;
    float tempo;

    // Start is called before the first frame update
    void Start()
    {
        
        liga = false;
        missaum.enabled = true;
        ContaCollider = false;

    }

    // Update is called once per frame
    void Update()
    {
  
        

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

        if (ContaCollider)
        {
            missaum.enabled = false;
            audioM.clip = ThankYou;
            audioM.Play();
            liga = true;
            GameController.instancia.AtualPremio = GameController.instancia.Premios[Random.Range(0, 5)];
            GameController.instancia.Dineiro += GameController.instancia.AtualPremio;
            GanhandoMoney.instancia.Tocar = true;
            //GameController.instancia.Missao1Ativo = false;
            GameController.instancia.QuantidadeDeEntregas++;
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
}

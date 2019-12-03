using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missao1 : MonoBehaviour
{
   
    public bool liga;
    public AudioSource audio;
    public AudioClip ThankYou;

    // Start is called before the first frame update
    void Start()
    {
        
        liga = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (liga)
        {
           GanhandoMoney.instancia.Dollar.SetActive(true);
           GanhandoMoney.instancia.ativaTempo = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pizza") && GameController.instancia.Missao1Ativo)
        {
            audio.clip = ThankYou;
            audio.Play();
            liga = true;
            GameController.instancia.AtualPremio=GameController.instancia.Premios[Random.Range(0, 5)];
            GameController.instancia.Dineiro += GameController.instancia.AtualPremio;
            GameController.instancia.Missao1Ativo = false;
            GameController.instancia.QuantidadeDeEntregas++;
            
        }
    }
}

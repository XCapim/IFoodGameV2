using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missao1 : MonoBehaviour
{
   public float Premio;
    public bool liga;

    // Start is called before the first frame update
    void Start()
    {
        Premio = 35f;
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
            liga = true;
            GameController.instancia.AtualPremio=GameController.instancia.Premios[Random.Range(0, 5)];
            GameController.instancia.Dineiro += GameController.instancia.AtualPremio;
            GameController.instancia.Missao1Ativo = false;
            GameController.instancia.QuantidadeDeEntregas++;
            
        }
    }
}

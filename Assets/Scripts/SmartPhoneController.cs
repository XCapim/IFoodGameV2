using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartPhoneController : MonoBehaviour
{
    public static SmartPhoneController instancia = null;
    public Text Tempo,TempoMinuto,Atropelado, QuantidadeDeEntregas, SaldoBancario;
    public float tempo;
    int tempoMinuto;


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        tempoMinuto = 1;
        tempo = 60f;
    }

    // Update is called once per frame
    void Update()
    {

        AtualizaHud();
        tempo -= Time.deltaTime;

        if (tempo <= 0f)
        {
            tempoMinuto--;
            tempo = 60f;
        }
        else if (tempo >= 60f)
        {
            tempo = 60f;
            tempoMinuto++;
            tempo = 0f;
        }

    }


    private void AtualizaHud()
    {
        SaldoBancario.text = "$ " + GameController.instancia.Dineiro;
        QuantidadeDeEntregas.text = GameController.instancia.QuantidadeDeEntregas.ToString();
        Tempo.text =Mathf.Round( tempo).ToString();
        TempoMinuto.text = tempoMinuto.ToString()+ ":";
        Atropelado.text = GameController.instancia.Atropelados.ToString();
    }


   

}

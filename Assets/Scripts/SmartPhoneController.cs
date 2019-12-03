using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartPhoneController : MonoBehaviour
{
    public static SmartPhoneController instancia = null;
    public GameObject Panel;
    public Text NomeApp, TextoValor;
    public GameObject Seta;
    sbyte velocidade;
    float PosYBaixo;
    float PosYAlto;
    bool ShowSmartPhone;


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        velocidade = 10;
        PosYAlto = 461.42f;
        PosYBaixo = -303.12f;
        transform.position = new Vector3(transform.position.x, PosYBaixo, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2"))
        {

            ShowSmartPhone = !ShowSmartPhone;

        }

        if (ShowSmartPhone)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + velocidade, 0);
            if (transform.position.y >= PosYAlto)
            {
                transform.position = new Vector3(transform.position.x, PosYAlto, 0);
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - velocidade, 0);
            if (transform.position.y <= PosYBaixo)
            {
                transform.position = new Vector3(transform.position.x, PosYBaixo, 0);
            }
        }


    }

    public void ButtomDinheiro()
    {
        Panel.SetActive(true);
        NomeApp.text = "Seu Dinheiro";
        TextoValor.text = "$ " + GameController.instancia.Dineiro;
        Seta.SetActive(false);
    }

    public void ButtomVoltar()
    {
        Panel.SetActive(false);
    }

    public void ButtomIFood()
    {
        Panel.SetActive(true);
        NomeApp.text = "Entregas";
        

        if (GameController.instancia.Missao1Ativo)
        {
            TextoValor.text = "Entrega do Pedro $35";
        }
        Seta.SetActive(false);
    }

    public void ButtomGPS()
    {
        Panel.SetActive(true);
        NomeApp.text = "Rota";
        TextoValor.text = "";
        Seta.SetActive(true);

     
    }

   

}

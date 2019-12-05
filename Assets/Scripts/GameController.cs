using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instancia = null;
    public GameObject LimeteMouse;
    public bool SpawnaMission1,Missao1Ativo,AtivaTempo;
    public float Dineiro,Tempo,QuantidadeDeEntregas,Atropelados,AtualPremio,AtualPerdePremio;
    public float[] Premios;
    public float[] PerdePremio;


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Atropelados = 0f;
        QuantidadeDeEntregas = 0f;
        Tempo = 0f;
        AtivaTempo = false;
        Dineiro = 0f;
        SpawnaMission1 = true;
        Missao1Ativo = true;
    }

    // Update is called once per frame
    void Update()
    {
        ComparaPosicaoMouse();

        

      
    }

    private void ComparaPosicaoMouse()
    {
        if (Input.mousePosition.x >= LimeteMouse.transform.position.x)
        {
            FindObjectOfType<LancaDireita>().AtivaJogarPizza = false;
            FindObjectOfType<LancaEsquerda>().AtivaLancaPizza = false;
        }
        else
        {
            FindObjectOfType<LancaDireita>().AtivaJogarPizza = true;
            FindObjectOfType<LancaEsquerda>().AtivaLancaPizza = true;
        }
    }

  
}

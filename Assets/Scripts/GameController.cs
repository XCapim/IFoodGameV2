using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instancia = null;
    public bool SpawnaMission1,Missao1Ativo,AtivaTempo;
    public float Dineiro,Tempo,QuantidadeDeEntregas,Atropelados,AtualPremio;
    public float[] Premios;


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
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
        if (SpawnaMission1)
        {
            Missao1();
        }

                   
        
    }

    private void Missao1()
    {
        if (SpawnaMission1)
        {
            GameObject Missao = Instantiate(Resources.Load("Missao1"), new Vector3(-11.42f, 42.5f, 0f), Quaternion.identity) as GameObject;
            SpawnaMission1 = false;
        }
    }

  
}

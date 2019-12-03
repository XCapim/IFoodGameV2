using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instancia = null;
    public bool SpawnaMission1,Missao1Ativo,ganhando,AtivaTempo;
    public float Dineiro,Tempo;
    public Text IconeGanhandoGrana; 


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Tempo = 0f;
        AtivaTempo = false;
        IconeGanhandoGrana.enabled = false;
        ganhando = false;
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


        if (ganhando)
        {

           GameController.instancia.IconeGanhandoGrana.enabled = true;
            IconeGanhandoGrana.transform.position = new Vector3(IconeGanhandoGrana.transform.position.x, IconeGanhandoGrana.transform.position.y + 0.01f, 0);
            IconeGanhandoGrana.color = new Color(IconeGanhandoGrana.color.r, IconeGanhandoGrana.color.g, IconeGanhandoGrana.color.b, IconeGanhandoGrana.color.a - 0.5f * Time.deltaTime);
            IconeGanhandoGrana.text = "$" + FindObjectOfType<Pizza>().Premio35;
            AtivaTempo = true;
            if (AtivaTempo)
            {
                Tempo += Time.deltaTime;
               
            }

            if (Tempo >= 3)
            {
                IconeGanhandoGrana.enabled = false;
            }
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

    private void Grana()
    {

        
       
        
    }
}

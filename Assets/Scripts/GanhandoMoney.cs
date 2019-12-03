using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GanhandoMoney : MonoBehaviour
{
    public static GanhandoMoney instancia = null;
    public GameObject Dollar;
    public Text dolla;
    public bool ativaTempo;
    public float tempo;


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Dollar.SetActive(false);
        ativaTempo = false;
        tempo = 0f;
       

    }

    // Update is called once per frame
    void Update()
    {


        AttText();
        

        if (ativaTempo)
        {
            tempo += Time.deltaTime;
        }

        if (tempo >= 3f)
        { 
           FindObjectOfType<Missao1>().liga = false;
           Dollar.SetActive(false);
           ativaTempo = false;
           tempo = 0;
        }


    }

   void AttText()
    {
        dolla.text = "$" + GameController.instancia.AtualPremio.ToString();
    }
}

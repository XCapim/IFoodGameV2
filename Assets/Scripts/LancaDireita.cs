using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancaDireita : MonoBehaviour
{
   bool AtivaTempoPizza;
   float TempoPizza,velocidade;


    // Start is called before the first frame update
    void Start()
    {
        TempoPizza = 0f;
        AtivaTempoPizza = true;
        velocidade = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (AtivaTempoPizza)
        {

            TempoPizza += Time.deltaTime;


        }
        if (TempoPizza >= 1f)
        {
            TempoPizza = 1f;
            AtivaTempoPizza = false;

            if (Input.GetButton("Fire3") && TempoPizza == 1f)
            {
                SpawnaPizzaDireita();
                TempoPizza = 0f;
                AtivaTempoPizza = true;
            }
        }
    }


    private void SpawnaPizzaDireita()
    {
        GameObject PizzaDir = Instantiate(Resources.Load("Pizza"), transform.position, Quaternion.identity) as GameObject;
        FindObjectOfType<Pizza>().rb.velocity = transform.right * velocidade;

    }
}

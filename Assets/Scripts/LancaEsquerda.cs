using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancaEsquerda : MonoBehaviour
{
    public bool AtivaTempoPizza,AtivaLancaPizza;
    float TempoPizza,velocidade;
    public AudioSource audioEsq;
    public AudioClip jogou;

    // Start is called before the first frame update
    void Start()
    {
        TempoPizza = 0f;
        AtivaTempoPizza = true;
        AtivaLancaPizza = true;
        velocidade = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (AtivaTempoPizza)
        {

            TempoPizza += Time.deltaTime;


        }
        if (TempoPizza >= 1.5f)
        {
            TempoPizza = 1.5f;
            AtivaTempoPizza = false;

            if (Input.GetButton("Fire1") && TempoPizza == 1.5f && AtivaLancaPizza)
            {
                audioEsq.clip = jogou;
                audioEsq.Play();
                GetComponentInParent<PlayerController>().anim.SetBool("LancaEsq", true);
                SpawnaPizzaEsquerda();
                TempoPizza = 0f;
                AtivaTempoPizza = true;
            }
            else
            {
                GetComponentInParent<PlayerController>().anim.SetBool("LancaEsq", false);
            }
        }
    }

    private void SpawnaPizzaEsquerda()
    {
        GameObject PizzaEsq = Instantiate(Resources.Load("Pizza"), transform.position, Quaternion.identity) as GameObject;
        FindObjectOfType<Pizza>().rb.velocity = -transform.right * velocidade;

    }
}

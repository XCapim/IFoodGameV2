﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancaDireita : MonoBehaviour
{
    public bool AtivaTempoPizza,AtivaJogarPizza;
    float TempoPizza,velocidade;
    public AudioSource audioDir;
    public AudioClip jogou;
    


    // Start is called before the first frame update
    void Start()
    {
        TempoPizza = 0f;
        AtivaTempoPizza = true;
        AtivaJogarPizza = true;
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

            if (Input.GetButton("Fire2") && TempoPizza == 1.5f && AtivaJogarPizza)
            {
                audioDir.clip = jogou;
                audioDir.Play();
                GetComponentInParent<PlayerController>().anim.SetBool("LancaDir", true);
                SpawnaPizzaDireita();
                TempoPizza = 0f;
                AtivaTempoPizza = true;
            }
            else
            {
                GetComponentInParent<PlayerController>().anim.SetBool("LancaDir",false);
            }
        }
    }


    private void SpawnaPizzaDireita()
    {
        GameObject PizzaDir = Instantiate(Resources.Load("Pizza"), transform.position, Quaternion.identity) as GameObject;
        FindObjectOfType<Pizza>().rb.velocity = transform.right * velocidade;

    }
}

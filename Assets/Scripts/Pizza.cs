using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float Premio35;


  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Premio35 = 35f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.9f);
      

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("missao")&& GameController.instancia.Missao1Ativo)
        {
            GameController.instancia.Dineiro += Premio35;
            GameController.instancia.Missao1Ativo = false;
            GameController.instancia.ganhando = true;
        }
    }

}

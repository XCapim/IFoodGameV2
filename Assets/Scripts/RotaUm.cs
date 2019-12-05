using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaUm : MonoBehaviour
{
    public GameObject [] locais;
    public int localAtual=0;
    public float velocidade = 10f;
    float giro;

    // Start is called before the first frame update
    void Start()
    {
        localAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(locais[localAtual].transform);
        transform.Rotate(0, -90, 0);


        if (Vector2.Distance(transform.position, locais[localAtual].transform.position)<0.1f)
        {
            if (localAtual < locais.Length - 1)
            {
                localAtual++;
            }
            else
            {
                localAtual = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, locais[localAtual].transform.position, velocidade * Time.deltaTime);

    

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("rota"))
        {
            
        }
    }
}

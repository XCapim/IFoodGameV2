using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instancia = null;
    float Speed, Curva, Tempo;
    bool Parado, AtivaTempo;
    public Animator anim;
    public Rigidbody2D rb;
    public AudioSource audio;
    public AudioClip parado, andando;




    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

        AtivaTempo = false;
        Parado = false;
        Tempo = 0f;
        Speed = 0f;
        Curva = 100f;
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {



        if (audio.isPlaying == false)
        {
          
            audio.Play();
        }




            if( Parado)
            {
            audio.clip = parado;
            }

            else if( Parado == false)
             {

                audio.clip = andando;
             }






        if (Input.GetAxis("Vertical") > 0f)
        {
            Speed = 10f;
            rb.velocity = transform.up * Speed;
            
            SpawnandoFumaca();

            if (Input.GetAxis("Vertical") > 0f && Parado == true)
            {
                GameObject Fumaca = Instantiate(Resources.Load("Fumaca"), transform.position, Quaternion.identity) as GameObject;
                Parado = false;
            }
        }

        else if (Input.GetAxis("Vertical") < 0f)
        {
            Speed = -5f;
            rb.velocity = transform.up * Speed;
          
            Parado = true;
        }

        else if (Input.GetAxis("Vertical") == 0)
        {
            Speed = 0f;
            rb.velocity = transform.up * Speed;
            Parado = true;
            anim.SetBool("Direita", false);
            anim.SetBool("Esqueda", false);
        }


        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("Esqueda", false);
            anim.SetBool("Direita", true);
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * Curva, Space.World);
      


        }
        else if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("Direita", false);
            anim.SetBool("Esqueda", true);
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * Curva, Space.World);
        


        }

        else if (Input.GetAxis("Horizontal") == 0)
        {

            anim.SetBool("Direita", false);
            anim.SetBool("Esqueda", false);
            transform.Rotate(new Vector3(0, 0, 0), Space.Self);
      


        }


    }



    private void SpawnandoFumaca()
    {
        float TempoSpawn = 1.5f;

        if (Parado == false)
        {
            AtivaTempo = true;
        }
        else
        {
            AtivaTempo = false;
        }

        if (AtivaTempo)
        {
            Tempo += Time.deltaTime;
        }

        if (Tempo >= TempoSpawn)
        {
            GameObject Fumaca = Instantiate(Resources.Load("Fumaca"), transform.position, Quaternion.identity) as GameObject;
            Tempo = 0f;
        }
    }








}

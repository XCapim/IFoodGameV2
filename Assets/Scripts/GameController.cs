using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float missions;

    // Start is called before the first frame update
    void Start()
    {
        missions = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    private void Missao1()
    {
        if (missions <= 1)
        {
            GameObject Missao = Instantiate(Resources.Load("Missao1"), new Vector3(-11.42f, 42.5f, 0f), Quaternion.identity) as GameObject;
        }
    }
}

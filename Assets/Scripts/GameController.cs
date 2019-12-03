using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool SpawnaMission1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnaMission1 = true;
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

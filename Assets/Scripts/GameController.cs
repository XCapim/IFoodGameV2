using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    bool mission1;

    // Start is called before the first frame update
    void Start()
    {
        mission1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mission1)
        {
            Missao1();
        }
        
        
    }

    private void Missao1()
    {
        if (mission1)
        {
            GameObject Missao = Instantiate(Resources.Load("Missao1"), new Vector3(-11.42f, 42.5f, 0f), Quaternion.identity) as GameObject;
            mission1 = false;
        }
    }
}

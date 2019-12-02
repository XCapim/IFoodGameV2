using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FumacaDestroi : MonoBehaviour
{
    float Tempo;
    bool AtivaTempo;

    // Start is called before the first frame update
    void Start()
    {
        AtivaTempo = true;
    }

    // Update is called once per frame
    void Update()
    {
       if(AtivaTempo)
        {
            Tempo += Time.deltaTime;
        }

        if (Tempo >= 0.8f)
        {
            Destroy(this.gameObject);
        }
    }
}

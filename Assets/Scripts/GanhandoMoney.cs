using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GanhandoMoney : MonoBehaviour
{
    public Text IconeGanhandoGrana;
    bool AtivaTempo;
    float Tempo;

    // Start is called before the first frame update
    void Start()
    {
        IconeGanhandoGrana = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameController.instancia.IconeGanhandoGrana.enabled = true;
        IconeGanhandoGrana.transform.position = new Vector3(IconeGanhandoGrana.transform.position.x, IconeGanhandoGrana.transform.position.y + 0.01f, 0);
        IconeGanhandoGrana.color = new Color(IconeGanhandoGrana.color.r, IconeGanhandoGrana.color.g, IconeGanhandoGrana.color.b, IconeGanhandoGrana.color.a - 0.5f * Time.deltaTime);
        IconeGanhandoGrana.text = "$" + FindObjectOfType<Pizza>().Premio35;
        AtivaTempo = true;
        if (AtivaTempo)
        {
            Tempo += Time.deltaTime;

        }

        if (Tempo >= 3)
        {
            Destroy(IconeGanhandoGrana);
        }
    }
}

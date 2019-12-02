using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartPhoneController : MonoBehaviour
{
    public static SmartPhoneController instancia = null;
    public GameObject PanelDinheiro,PanelGps,PanelIFood, AppDinheiro, AppGPS,AppIFood;
    sbyte velocidade;
    float PosYBaixo;
    float PosYAlto;
    bool ShowSmartPhone;


    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        PanelDinheiro.SetActive(false);
        PanelGps.SetActive(false);
        PanelIFood.SetActive(false);
        AppDinheiro.SetActive(true);
        AppGPS.SetActive(true);
        AppIFood.SetActive(true);
        velocidade = 10;
        PosYAlto = 461.42f;
        PosYBaixo = -303.12f;
        transform.position = new Vector3(transform.position.x, PosYBaixo, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2"))
        {

            ShowSmartPhone = !ShowSmartPhone;

        }

        if (ShowSmartPhone)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + velocidade, 0);
            if (transform.position.y >= PosYAlto)
            {
                transform.position = new Vector3(transform.position.x, PosYAlto, 0);
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - velocidade, 0);
            if (transform.position.y <= PosYBaixo)
            {
                transform.position = new Vector3(transform.position.x, PosYBaixo, 0);
            }
        }

    }


    public void AtivaPaineDinheiro()
    {
        PanelDinheiro.SetActive(true);
        AppGPS.SetActive(false);
        AppIFood.SetActive(false);
      

    }

    public void DesativaPainelDinheiro()
    {
        PanelDinheiro.SetActive(false);
        AppGPS.SetActive(true);
        AppIFood.SetActive(true);
        AppDinheiro.SetActive(true);
    }

    public void AtivaPaineGPS()
    {
        PanelGps.SetActive(true);
        AppIFood.SetActive(false);
        AppGPS.SetActive(true);
    }

    public void DesativaPainelGPS()
    {
        PanelGps.SetActive(false);
        AppDinheiro.SetActive(true);
        AppIFood.SetActive(true);
        AppGPS.SetActive(true);
    }

    public void AtivaPainelIFood()
    {
        PanelIFood.SetActive(true);
        AppGPS.SetActive(false);
        AppDinheiro.SetActive(false);
        

    }

    public void DesativaPainelIFood()
    {
        PanelIFood.SetActive(false);
        AppGPS.SetActive(true);
        AppDinheiro.SetActive(true);
        
    }
}

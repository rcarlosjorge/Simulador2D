using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSemaforos : MonoBehaviour
{
    //Semaforo 1 y 3
    public GameObject[] Semaforo_red13;
    public GameObject[] Semaforo_yellow13;
    public GameObject[] Semaforo_verde13;
    public bool Semaforo_unotres_verde;

    //Semaforo 2 y 4
    public GameObject[] Semaforo_red24;
    public GameObject[] Semaforo_yellow24;
    public GameObject[] Semaforo_verde24;
    public bool Semaforo_doscuatro_verde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Traffic());
    }

 void SemaforoRojo()
    {
        //Semaforo 1 y 3 
        Semaforo_red13[0].SetActive(true);
        Semaforo_red13[1].SetActive(true);
        Semaforo_yellow13[0].SetActive(false);
        Semaforo_yellow13[1].SetActive(false);
        Semaforo_verde13[0].SetActive(false);
        Semaforo_verde13[1].SetActive(false);

        //Semaforo 2 y 4
        Semaforo_red24[0].SetActive(false);
        Semaforo_red24[1].SetActive(false);
        Semaforo_yellow24[0].SetActive(false);
        Semaforo_yellow24[1].SetActive(false);
        Semaforo_verde24[0].SetActive(true);
        Semaforo_verde24[1].SetActive(true);

        Semaforo_unotres_verde = false;
        Semaforo_doscuatro_verde = true;
    }
    void Semaforo13Amarillo()
    {
        //Semaforo 1 y 3
        Semaforo_red13[0].SetActive(false);
        Semaforo_red13[1].SetActive(false);
        Semaforo_yellow13[0].SetActive(true);
        Semaforo_yellow13[1].SetActive(true);
        Semaforo_verde13[0].SetActive(false);
        Semaforo_verde13[1].SetActive(false);

        //Semaforo 2 y 4
        Semaforo_red24[0].SetActive(true);
        Semaforo_red24[1].SetActive(true);
        Semaforo_yellow24[0].SetActive(false);
        Semaforo_yellow24[1].SetActive(false);
        Semaforo_verde24[0].SetActive(false);
        Semaforo_verde24[1].SetActive(false);
    }
    void Semaforo24Amarillo()
    {
        //Semaforo 1 y 3 
        Semaforo_red13[0].SetActive(true);
        Semaforo_red13[1].SetActive(true);
        Semaforo_yellow13[0].SetActive(false);
        Semaforo_yellow13[1].SetActive(false);
        Semaforo_verde13[0].SetActive(false);
        Semaforo_verde13[1].SetActive(false);

        //Semaforo 2 y 4
        Semaforo_red24[0].SetActive(false);
        Semaforo_red24[1].SetActive(false);
        Semaforo_yellow24[0].SetActive(true);
        Semaforo_yellow24[1].SetActive(true);
        Semaforo_verde24[0].SetActive(false);
        Semaforo_verde24[1].SetActive(false);
    }
    void SemaforoVerde()
    {
        //Semaforo 1 y 3
        Semaforo_red13[0].SetActive(false);
        Semaforo_red13[1].SetActive(false);
        Semaforo_yellow13[0].SetActive(false);
        Semaforo_yellow13[1].SetActive(false);
        Semaforo_verde13[0].SetActive(true);
        Semaforo_verde13[1].SetActive(true);

        //Semaforo 2 y 4
        Semaforo_red24[0].SetActive(true);
        Semaforo_red24[1].SetActive(true);
        Semaforo_yellow24[0].SetActive(false);
        Semaforo_yellow24[1].SetActive(false);
        Semaforo_verde24[0].SetActive(false);
        Semaforo_verde24[1].SetActive(false);

        Semaforo_unotres_verde = true;
        Semaforo_doscuatro_verde = false;
    }
    IEnumerator Traffic()
    {
        while (true)
        {
            SemaforoRojo();
            yield return new WaitForSeconds(1);
            Semaforo13Amarillo();
            yield return new WaitForSeconds(1);
            Semaforo24Amarillo();
            yield return new WaitForSeconds(1);
            SemaforoVerde();
            yield return new WaitForSeconds(1);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaforo2y4 : MonoBehaviour
{
    public GameObject Semaforo_red;
    public GameObject Semaforo_yellow;
    public GameObject Semaforo_verde;
    public bool Semaforo_doscuatro_verde;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trafficlight());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Semaforo24Green() 
    {
Semaforo_verde.SetActive(true);
Semaforo_yellow.SetActive(false);
Semaforo_red.SetActive(false);
Semaforo_doscuatro_verde = true;
    }

    void Semaforo24Yellow() 
    {
Semaforo_verde.SetActive(false);
Semaforo_yellow.SetActive(true);
Semaforo_red.SetActive(false);
Semaforo_doscuatro_verde = true;
    }

    void Semaforo24Red() 
    {
Semaforo_verde.SetActive(false);
Semaforo_yellow.SetActive(false);
Semaforo_red.SetActive(true);
Semaforo_doscuatro_verde = false;
    }

    IEnumerator trafficlight() {
        while(true) {
        Semaforo24Red();
        yield return new WaitForSeconds(2);
        Semaforo24Yellow();
        yield return new WaitForSeconds(2);
        Semaforo24Green();
        yield return new WaitForSeconds(2);
        }
    }
}

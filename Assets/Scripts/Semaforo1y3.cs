using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo1y3 : MonoBehaviour
{
    public GameObject Semaforo_red;
    public GameObject Semaforo_yellow;
    public GameObject Semaforo_verde;
    public bool Semaforo_unotres_verde;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(traffic());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void Semaforo13Green() 
    {
Semaforo_verde.SetActive(true);
Semaforo_yellow.SetActive(false);
Semaforo_red.SetActive(false);
Semaforo_unotres_verde = true;
    }

    void Semaforo13Yellow() 
    {
Semaforo_verde.SetActive(false);
Semaforo_yellow.SetActive(true);
Semaforo_red.SetActive(false);
Semaforo_unotres_verde = true;
    }

    void Semaforo13Red() 
    {
Semaforo_verde.SetActive(false);
Semaforo_yellow.SetActive(false);
Semaforo_red.SetActive(true);
Semaforo_unotres_verde = false;
    }

    IEnumerator traffic() {
        while(true) {
            Semaforo13Red();
            yield return new WaitForSeconds(2);
            Semaforo13Yellow();
            yield return new WaitForSeconds(2);
        Semaforo13Green();
        yield return new WaitForSeconds(2);
        }
    }
}

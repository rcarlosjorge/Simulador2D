using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] Car1;
    public GameObject[] Car2;
    public GameObject[] Car3;
    public GameObject[] Car4;
    public ControlSemaforos control;
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("Generatorcar", 1, 2f);
    }
     void Generatorcar() 
   {
       Instantiate(Car1[0], transform.position, Quaternion.identity);
       Instantiate(Car2[0], transform.position, Quaternion.identity);
       Instantiate(Car3[0], transform.position, Quaternion.identity);
       Instantiate(Car4[0], transform.position, Quaternion.identity);
   }
}

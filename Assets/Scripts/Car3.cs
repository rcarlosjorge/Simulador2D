using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car3 : MonoBehaviour
{
    public GameObject EstadoSema;
    public float Speed = 4f;
    public bool cn3;
    // Start is called before the first frame update
    void Start()
    {
        cn3 = false;
        transform.position = new Vector2(10.29f, 0.74f);
        transform.Rotate(0,0,90, Space.Self);
        EstadoSema = GameObject.Find("Control");
    }

    // Update is called once per frame
    void Update()
    {
         if(EstadoSema.GetComponent<ControlSemaforos>().Semaforo_unotres_verde || cn3)
        {
            transform.Translate(new Vector2(0, 2f) * Speed * Time.deltaTime);
        }
    }

   private void OnTriggerEnter2D(Collider2D colision)
{
    if (colision.tag == "DT1")
    {
        Destroy(this.gameObject);
    }
    if (colision.tag == "Control1")
    {
        cn3 = true;
    }
}
}

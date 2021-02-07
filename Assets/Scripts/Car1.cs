using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1 : MonoBehaviour
{
    public GameObject EstadoSema;
    public float Speed = 4f;
    public bool cn1;
    // Start is called before the first frame update
    void Start()
    {
        cn1 = false;
        transform.position = new Vector2(-10.38f, 0.03f);
        transform.Rotate(0,0,-90, Space.Self);
        EstadoSema = GameObject.Find("Control");
    }

    // Update is called once per frame
    void Update()
    {
        if(EstadoSema.GetComponent<ControlSemaforos>().Semaforo_unotres_verde || cn1)
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
        cn1 = true;
    }
}
}

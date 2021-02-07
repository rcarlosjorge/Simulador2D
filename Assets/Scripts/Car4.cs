using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car4 : MonoBehaviour
{
    public GameObject EstadoSema;
    public float Speed = 4f;
    public bool cn4;
    // Start is called before the first frame update
    void Start()
    {
        cn4 = false;
         transform.position = new Vector2(0.64f, -4.27f);
        transform.Rotate(0,0,0, Space.Self);
        EstadoSema = GameObject.Find("Control");
    }

    // Update is called once per frame
    void Update()
    {
         if(EstadoSema.GetComponent<ControlSemaforos>().Semaforo_doscuatro_verde || cn4)
        {
            transform.Translate(new Vector2(0, 2f) * Speed * Time.deltaTime);
        }
    }
   private void OnTriggerEnter2D(Collider2D colision)
{
    if (colision.tag == "DT2")
    {
        Destroy(this.gameObject);
    }
    if (colision.tag == "Control1")
    {
        cn4 = true;
    }
}
}

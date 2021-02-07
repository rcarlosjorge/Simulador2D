using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : MonoBehaviour
{
    public GameObject EstadoSema;
    public float Speed = 4f;
    public bool cn2;
    // Start is called before the first frame update
    void Start()
    {
        cn2 = false;
        transform.position = new Vector2(-0.28f, 4.49f);
        transform.Rotate(0,0,180, Space.Self);
        EstadoSema = GameObject.Find("Control");
    }

    // Update is called once per frame
    void Update()
    {
        if(EstadoSema.GetComponent<ControlSemaforos>().Semaforo_doscuatro_verde || cn2)
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
        cn2 = true;
    }
}
}

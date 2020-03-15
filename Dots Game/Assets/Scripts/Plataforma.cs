using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        //controla tamanho da plataforma
        transform.localScale = new Vector2(Mathf.PingPong(Time.time, 1), transform.localScale.y);
        //descer plataforma
        transform.Translate(new Vector2(0f,-velocidade*Time.deltaTime));
    }
}

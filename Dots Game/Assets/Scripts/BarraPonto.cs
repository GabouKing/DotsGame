using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraPonto : MonoBehaviour
{

    public float velocidade;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, -velocidade * Time.deltaTime));
    }
}

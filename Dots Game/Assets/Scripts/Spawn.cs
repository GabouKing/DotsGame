using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject plataformaPrefab;

    float tempo;
    public float tempoMin;
    public float tempoMax;
    public float tempoTotal;

    // Start is called before the first frame update
    void Start()
    {
        tempoTotal = Random.Range(tempoMin, tempoMax);
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;

        if(tempo >= tempoTotal)
        {
            Instantiate(plataformaPrefab,transform.position, transform.rotation);
            tempoTotal = Random.Range(tempoMin, tempoMax);
            tempo = 0f;
        }
    }
}

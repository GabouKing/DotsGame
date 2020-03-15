using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinhas : MonoBehaviour
{
    public RotacionarBolas   controle;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Ponto")
        {
            Destroy(collision.gameObject);
            controle.AtualizarPontuacao();
        }
        if (collision.gameObject.tag == "Plataforma")
        {
            controle.ChamarGameOver();
        }
    }
}

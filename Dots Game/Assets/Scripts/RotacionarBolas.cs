using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotacionarBolas : MonoBehaviour
{
    public float velocidade;
    bool direita = false;

    public GameObject gameOver;
    public int pontuacao;
    public Text pontoTxt;

    // Update is called once per frame

    void Update()
    {
    if (Input.GetMouseButtonDown(0))
    {
        direita = !direita;
            
        }
        if (direita == false)
        {
            //rotaciona para a esquerda
            transform.Rotate(new Vector3(0f, 0f, velocidade * Time.deltaTime));
        }
        else
        {
            //rotaciona para direita
            transform.Rotate(new Vector3(0f, 0f, -velocidade * Time.deltaTime));
        }

        
    }

    public void ChamarGameOver()
    {
        gameOver.SetActive(true);
    }
    public void ReiniciarGame()
    {
        SceneManager.LoadScene(0);
    }
    public void AtualizarPontuacao()
    {
        pontuacao++;
        pontoTxt.text = pontuacao.ToString();

    }
}

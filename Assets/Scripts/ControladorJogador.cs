using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{

    public float taxaMovimentacao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float altX, altY;

        // Cima e Baixo:
        if (Input.GetKey(KeyCode.UpArrow))
        {
            altY = 60 * Time.deltaTime * taxaMovimentacao;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            altY = -60 * Time.deltaTime * taxaMovimentacao;
        }
        else altY = 0;

        // Lado Esquerdo e Direito:

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            altX = -60 * Time.deltaTime * taxaMovimentacao;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            altX = 60 * Time.deltaTime * taxaMovimentacao;
        }
        else altX = 0;

        // Modificar Posição:

        Vector3 novaPos = new Vector3(altX, altY, 0);
        transform.position += novaPos;

        // Movimentação do Personagem - Cima
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 novaPos = new Vector3(0, 1, 0);
            transform.position = transform.position + novaPos;
        }

        // Movimentação do Personagem - Baixo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 novaPos = new Vector3(0, -1, 0);
            transform.position = transform.position + novaPos;
        }

        // Movimentação do Personagem - Esquerda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 novaPos = new Vector3(-1, 0, 0);
            transform.position = transform.position + novaPos;
        }

        // Movimentação do Personagem - Direita
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 novaPos = new Vector3(1, 0, 0);
            transform.position = transform.position + novaPos;
        }*/
    }
}

using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{

    public float taxaMovimentacao;
    public Geral JuizDoJogo;


    // Update is called once per frame
    void Update()
    {
        float altX, altY;

        // Cima e Baixo: (Posi��o Y)
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 468)
        {
            altY = 60 * Time.deltaTime * taxaMovimentacao;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > 32)
        {
            altY = -60 * Time.deltaTime * taxaMovimentacao;
        }
        else altY = 0;

        // Lado Esquerdo e Direito: (Posi��o X)

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 32)
        {
            altX = -60 * Time.deltaTime * taxaMovimentacao;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 928)
        {
            altX = 60 * Time.deltaTime * taxaMovimentacao;
        }
        else altX = 0;

        // Modificar Posi��o:

        Vector3 novaPos = new Vector3(altX, altY, 0);
        transform.position += novaPos;

        // Movimenta��o do Personagem - Cima
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 novaPos = new Vector3(0, 1, 0);
            transform.position = transform.position + novaPos;
        }

        // Movimenta��o do Personagem - Baixo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 novaPos = new Vector3(0, -1, 0);
            transform.position = transform.position + novaPos;
        }

        // Movimenta��o do Personagem - Esquerda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 novaPos = new Vector3(-1, 0, 0);
            transform.position = transform.position + novaPos;
        }

        // Movimenta��o do Personagem - Direita
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 novaPos = new Vector3(1, 0, 0);
            transform.position = transform.position + novaPos;
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Comida")
        {
            JuizDoJogo.MarcarPonto();

            // Volta para a posi��o horizontal original
            collision.GetComponent<ControladorObjetoVoador>().posicaoObj.x =
                collision.GetComponent<ControladorObjetoVoador>().posInicialX;
        }

        // Atualizar a posi��o vertical do objeto
        float posicaoY = Random.value * 468;
        collision.GetComponent<ControladorObjetoVoador>().posicaoObj.y = posicaoY;

        // Trocar a imagem do Objeto a ser coletado
        collision.GetComponent<ControladorObjetoVoador>().MudarImagem();
    }
}
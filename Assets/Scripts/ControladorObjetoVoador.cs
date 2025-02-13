using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ControladorObjetoVoador : MonoBehaviour
{

    public float deslocamentoObjeto; // Determinar a velocidade inicial do objeto
    public float incrementoVelocidade; // Determinar o aumento da velocidade por segundo
    public Sprite[] imagensObjetos;

    internal int sentidoV; // Para qual lado o objeto vai na vertical (-1: baixo 1: cima)
    internal Vector3 posicaoObj; // A variável em que indicamos a nova posição (X, Y, Z), dinamicamente
    internal float deslocamentoAbs; // O deslocamento aplicado ao objeto por quadro (update)
    internal int numImagemAtual = 0;

    public float posInicialX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Controle do sentido vertical para soma com o -1 para descer
        sentidoV = 1;
        posicaoObj = transform.position;
        posInicialX = transform.position.x;

        deslocamentoAbs = deslocamentoObjeto;

    }

    // Update is called once per frame
    void Update()
    {
        //Movimentação - Velocidade do deslocamento * sentidoV * Time.deltaTime * Velocidade dinâmica
        posicaoObj.y += deslocamentoAbs * sentidoV * Time.deltaTime;
        posicaoObj.x += deslocamentoAbs * Time.deltaTime;

        transform.position = posicaoObj;

        deslocamentoAbs += incrementoVelocidade * Time.deltaTime;


        // Limite Vertical
        if (transform.position.y > 468)
        {
            sentidoV = -1;
        }
        else if (transform.position.y < 32)
        {
            sentidoV = 1;
        }

    }  
        public void MudarImagem()
        {
            numImagemAtual += 1;

            if (numImagemAtual == imagensObjetos.Length)
            {
                numImagemAtual = 0;
            }

            GetComponent<Image>().sprite = imagensObjetos[numImagemAtual];
        }
}

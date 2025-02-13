using UnityEngine;
using UnityEngine.UI;

public class Geral : MonoBehaviour
{

    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public AudioSource somPontoGanho;

    public GameObject Introducao, GameOver;
    public ControladorObjetoVoador objetoVoador;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        //recordeNum = 0;
        AtualizarTextoPlacar();

        Time.timeScale = 0;
    }
    
    public void MarcarPonto()
    {
        placarJogadorNum += 1;

        if (recordeNum < placarJogadorNum)
        {
            recordeNum += 1;
        }

        AtualizarTextoPlacar();

        somPontoGanho.Play();

    }

    public void AtualizarTextoPlacar()
    {
        placarJogadorTexto.text = "ITENS COLETADOS: " + placarJogadorNum;
        recordeTexto.text = "RECORDE ATUAL: " + recordeNum;
    }

    public void ComecarJogo()
    {
        //"Descongelar" o tempo
        Time.timeScale = 1;

        // Sumir com a tela de Boas-Vindas OU a de Game Over
        Introducao.SetActive(false);
        GameOver.SetActive(false);

        // Voltar o objeto voador à sua posição original
        objetoVoador.deslocamentoAbs = objetoVoador.deslocamentoObjeto;
        objetoVoador.posicaoObj.x = objetoVoador.posInicialX;

        // Zerar o placar
        placarJogadorNum = 0;
        AtualizarTextoPlacar();
    }
}

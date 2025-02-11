using UnityEngine;
using UnityEngine.UI;

public class Geral : MonoBehaviour
{

    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public AudioSource somPontoGanho, somPontoPerdido;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        recordeNum = 0;

        AtualizarTextoPlacar();
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
}

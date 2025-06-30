using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class GameManager : MonoBehaviour
{
     public GameObject playButton;
        public GameObject replayButton;
        public TMP_Text  textoBranco;
        public TMP_Text  textoPreto;
    
        private int pontosBranco = 0;
        private int pontosPreto = 0;
        private bool jogoEmAndamento = false;
        public bool TurnoBranco { get; private set; } = true;
    
        void Start()
        {
            // Inicializa a interface
            AtualizarTextoPontuacao();
            replayButton.SetActive(false);
        }
    
        public void IniciarJogo()
        {
            jogoEmAndamento = true;
            playButton.SetActive(false);
            replayButton.SetActive(true);
            pontosBranco = 0;
            pontosPreto = 0;
            AtualizarTextoPontuacao();
    
            // Aqui você pode iniciar o tabuleiro e posicionar as peças
            Debug.Log("Jogo iniciado!");
        }
    
        public void JogarNovamente()
        {
            pontosBranco = 0;
            pontosPreto = 0;
            AtualizarTextoPontuacao();
    
            // Reiniciar o tabuleiro aqui
            Debug.Log("Jogo reiniciado!");
        }
    
        public void AdicionarPontoBranco()
        {
            pontosBranco++;
            AtualizarTextoPontuacao();
            MudarTurno();
        }
    
        public void AdicionarPontoPreto()
        {
            pontosPreto++;
            AtualizarTextoPontuacao();
            MudarTurno();
        }
    
        private void AtualizarTextoPontuacao()
        {
            textoBranco.text = "Branco: " + pontosBranco;
            textoPreto.text = "Preto: " + pontosPreto;
        }
        public void MudarTurno()
        {
            TurnoBranco = !TurnoBranco;
        }
}

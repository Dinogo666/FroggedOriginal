using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Pontua��o do jogador")]
    public int score = 0; // Pontos atuais

    // M�todo p�blico para adicionar pontos
    public void AdicionarPontos(int quantidade)
    {
        score += quantidade;
        Debug.Log($"Score atualizado: {score}");
    }

    // M�todo p�blico para resetar a pontua��o
    public void ResetarScore()
    {
        score = 0;
        Debug.Log("Score resetado.");
    }
}
    
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int quantidade = 1; // Pontos da moeda
    public GameManager gameManager; // Refer�ncia ao GameManager

    void OnTriggerEnter2D(Collider2D jogador)
    {
        if (jogador.CompareTag("Player"))
        {
            // Exemplo: adicionar pontos ao jogador
            gameManager.AdicionarPontos(quantidade);

            // Destr�i a moeda
            Destroy(gameObject);
        }
    }
}

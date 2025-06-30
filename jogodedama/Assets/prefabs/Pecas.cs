using UnityEngine;

public class Pecas : MonoBehaviour
{
    public bool isBranca;

    private GameManager gameManager;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        // Simula captura ao clicar em uma peça inimiga
        if (gameManager.TurnoBranco == !isBranca)
        {
            if (isBranca)
                gameManager.AdicionarPontoPreto();
            else
                gameManager.AdicionarPontoBranco();

            Destroy(gameObject);
        }
    }
}

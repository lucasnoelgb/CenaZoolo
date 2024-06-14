using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirporta : MonoBehaviour
{
    public GameObject door; // Porta a ser aberta
    public int id; // Identificador do objeto
    private static int[] correctOrder = { 0, 1, 2, 3, 4, 5 }; // Ordem correta dos objetos
    private static int currentIndex = 0; // Índice atual da ordem
    private static bool doorOpened = false; // Verifica se a porta já foi aberta

    void OnMouseDown()
    {
        // Verifica se a porta já foi aberta
        if (doorOpened)
            return;

        // Verifica se o objeto clicado é o próximo na ordem correta
        if (correctOrder[currentIndex] == id)
        {
            currentIndex++;
            Debug.Log("Objeto correto clicado: " + id);

            // Verifica se todos os objetos foram clicados na ordem correta
            if (currentIndex == correctOrder.Length)
            {
                AbriraPortinha();
                doorOpened = true;
                Debug.Log("Porta aberta!");
            }
        }
        else
        {
            // Reseta a sequência se o objeto não for o esperado
            currentIndex = 0;
            Debug.Log("Ordem incorreta. Sequência reiniciada.");
        }
    }

    void AbriraPortinha()
    {
        // Adicione a lógica para abrir a porta, por exemplo, movê-la para cima
        door.transform.position += new Vector3(0, 5, 0); // Move a porta 5 unidades para cima
    }
}
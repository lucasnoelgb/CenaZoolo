using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirporta : MonoBehaviour
{
    public GameObject door; // Porta a ser aberta
    public int id; // Identificador do objeto
    private static int[] correctOrder = { 0, 1, 2, 3, 4, 5 }; // Ordem correta dos objetos
    private static int currentIndex = 0; // �ndice atual da ordem
    private static bool doorOpened = false; // Verifica se a porta j� foi aberta

    void OnMouseDown()
    {
        // Verifica se a porta j� foi aberta
        if (doorOpened)
            return;

        // Verifica se o objeto clicado � o pr�ximo na ordem correta
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
            // Reseta a sequ�ncia se o objeto n�o for o esperado
            currentIndex = 0;
            Debug.Log("Ordem incorreta. Sequ�ncia reiniciada.");
        }
    }

    void AbriraPortinha()
    {
        // Adicione a l�gica para abrir a porta, por exemplo, mov�-la para cima
        door.transform.position += new Vector3(0, 5, 0); // Move a porta 5 unidades para cima
    }
}
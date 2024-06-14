using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D ou Setas
        float moveVertical = Input.GetAxis("Vertical"); // W/S ou Setas

        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;
        move.y = 0; // Garantir que não haja movimento vertical

        characterController.Move(move * moveSpeed * Time.deltaTime);
    }
}
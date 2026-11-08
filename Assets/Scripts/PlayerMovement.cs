using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 _moveDirection;

    public InputActionReference move;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = move.action.ReadValue<Vector2>();// Read Input 
        Vector2 vector_input = new Vector2(_moveDirection.x , _moveDirection.y );// Store Input in a Vector 
        transform.Translate(vector_input * moveSpeed * Time.deltaTime);//Move the object based on the input direction

    }

   

}

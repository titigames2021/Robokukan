using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;
   private Vector2 _moveDirection;
   [SerializeField] float moveSpeed;
   [SerializeField] InputActionReference move;
   




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();

       
    }

    // Update is called once per frame
    void Update()
    {
        #region Movement
        _moveDirection = move.action.ReadValue<Vector2>();// Read Input 
        Vector2 vector_input = new Vector2(_moveDirection.x , _moveDirection.y );// Store Input in a Vector 
        transform.Translate(vector_input * moveSpeed * Time.deltaTime);//Move the object based on the input direction
        #endregion

       

    }

    private void LateUpdate()
    {
      
    }



}

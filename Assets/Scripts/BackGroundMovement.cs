using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
    private float speed=1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Layer order close to far 
        switch (gameObject.layer)
        {
            case 6:
                speed = speed * 0.95f;
                break;
            case 7:
                speed = speed * 0.7f;
                break;
            case 8:
                speed = speed * 0.4f;
                break;
            case 9:
                speed= speed * 0.1f;
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
      
        gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}

using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
    
    Vector2 inputVector = Vector2.zero; // intialize our input vector

    if (Input.GetKey(KeyCode.W))
    {
    inputVector += Vector2.up; // "a += b" <=> "a = a + b"
    }

    if (Input.GetKey(KeyCode.S))
    {
    inputVector += Vector2.down;
    }

    if (Input.GetKey(KeyCode.D))
    {
    inputVector += Vector2.right;
    }

    if (Input.GetKey(KeyCode.A))
    {
    inputVector += Vector2.left;
    }

    Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
    Debug.Log("Resultant Vector: " + inputVector);
    Debug.Log("Resultant 3D Vector: " + inputXZPlane);
    sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

    } */

    public void MoveBall(Vector2 input){
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}

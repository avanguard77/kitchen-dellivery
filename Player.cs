using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotateSpead = 5f;
    private void Update()
    {
        Vector3 inputvector = new Vector2(0f, 0f);
        if (Input.GetKey(KeyCode.W))
        {
            inputvector.y += 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            inputvector.y -= 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            inputvector.x -= 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            inputvector.x += 1f;
        }

        inputvector = inputvector.normalized;

        Vector3 movementvector = new Vector3(inputvector.x * moveSpeed, 0f, inputvector.y * moveSpeed);
        transform.position += movementvector * Time.deltaTime * moveSpeed;
        
        // transform.LookAt(transform.position + movementvector, Vector3.up);
        transform.forward =Vector3.Slerp(transform.forward, movementvector, Time.deltaTime*rotateSpead); 
    }
}
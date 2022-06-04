using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    public float moveSpeed;
    private bool isTurning;
    public float turnSpeed;
   

    // Start is called before the first frame update
   
    void Update()
    {
        // This is movement code
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        // this is turning
        if (Input.GetMouseButtonDown(1))
        {
            isTurning = true;
        }
        if (isTurning == true)
        {
            float rot = Input.GetAxis("Mouse X") * turnSpeed;
            transform.Rotate(Vector3.up, rot * Time.deltaTime);
        }
        if (Input.GetMouseButtonUp(1))
        {
            isTurning = false;
        }
    }
}

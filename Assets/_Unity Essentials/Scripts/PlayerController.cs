using UnityEngine;

// Controls player movement and rotation.
public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5.0f;
    public float speed = 5.0f; // Set player's movement speed.
    public float rotationSpeed = 120.0f; // Set player's rotation speed.

    private Rigidbody rb; // Reference to player's Rigidbody.

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }


    // Handle physics-based movement and rotation.
    private void FixedUpdate()
    {
        // Move player based on vertical input.
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        // Rotate player based on horizontal input.
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}

using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float moveSpeed = 5f; // Speed of the player movement
    [SerializeField] private float jumpForce = 3f; // Force applied when the player jumps
    [SerializeField] private LayerMask groundLayer; // Layer mask to identify ground objects
    [SerializeField] private Transform groundCheck; // Transform to check if the player is grounded
    private Animator animator; // Reference to the Animator component for animations

    private bool isGrounded; // Flag to check if the player is on the ground



    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    private void Awake()
    {
        animator = GetComponent<Animator>(); // Get the Animator component attached to the player
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the player
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement(); // Call the HandleMovement method to process player input
        HandleJump(); // Call the HandleJump method to process player jumping
        UpdateAnimation(); // Call the UpdateAnimation method to update player animations
    }
    private void HandleMovement()
    {
        float moveInput = Input.GetAxis("Horizontal"); // Get horizontal input (A/D or Left/Right arrow keys)
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y); // Set the horizontal velocity of the player
        if(moveInput > 0)transform.localScale = new Vector3(1, 1, 1); // Flip the player sprite to face right
        else if (moveInput < 0) transform.localScale = new Vector3(-1, 1, 1); // Flip the player sprite to face left
    }
    private void HandleJump()
    {
        if(Input.GetButtonDown("Jump")&& isGrounded) // Check if the jump button is pressed
        {
           rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Apply a vertical force to the player
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer); // Check if the player is grounded using a circle overlap
    }
    private void UpdateAnimation()
    {
        bool isRunning = Mathf.Abs(rb.linearVelocity.x) > 0.1f; // Check if the player is running based on horizontal velocity
        bool isJumping = !isGrounded; // Check if the player is jumping based on the isGrounded flag
        animator.SetBool("isRunning", isRunning); // Set the "isRunning" parameter in the Animator
        animator.SetBool("isJumping", isJumping); // Set the "isJumping" parameter in the Animator
    }
}

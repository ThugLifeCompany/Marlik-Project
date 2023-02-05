using UnityEngine;

public class Player : MonoBehaviour
{
	[Header("Controllers")]
	[SerializeField] private float speed;
	[SerializeField] private float jumpForce;

	[Header("Settrings")]
	[SerializeField] private Transform groundCheckTransform;
	[SerializeField] private LayerMask groundLayer;
	private bool isGrounded;
	private float inputX;
	private Rigidbody2D m_Rigidbody2D;

	private void Start()
	{
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		Movement();

		//Rotate Player Face Toward Movement
		GetComponent<SpriteRenderer>().flipX |= inputX < 0;
		GetComponent<SpriteRenderer>().flipX &= inputX <= 0;
	}

	private void FixedUpdate() => isGrounded = Physics2D.OverlapCircle(groundCheckTransform.position, 0.2f, groundLayer);

	private void Movement()
	{
		//Movement
		inputX = Input.GetAxis("Horizontal");

		m_Rigidbody2D.velocity = new Vector2(speed * inputX, m_Rigidbody2D.velocity.y);

		//Jump
		if (isGrounded)
			if (Input.GetKeyDown(KeyCode.Space))
				m_Rigidbody2D.velocity = new Vector2(m_Rigidbody2D.velocity.x, jumpForce);
	}
}

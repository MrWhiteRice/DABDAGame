using UnityEngine;

public class Movement : MonoBehaviour
{
	Rigidbody2D rb;
	Vector2 moveDir = Vector2.zero;

	[SerializeField]
	float moveSpeed = 5;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		GetInput();
		
		rb.velocity = moveDir.normalized * moveSpeed;
	}

	void GetInput()
	{
		if(Input.GetKey(KeyCode.W))
		{
			moveDir.y = 1;
		}
		else if(Input.GetKey(KeyCode.S))
		{
			moveDir.y = -1;
		}

		if(Input.GetKey(KeyCode.A))
		{
			moveDir.x = -1;
		}
		else if(Input.GetKey(KeyCode.D))
		{
			moveDir.x = 1;
		}

		if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
		{
			moveDir.x = 0;
		}
		if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
		{
			moveDir.y = 0;
		}
	}
}
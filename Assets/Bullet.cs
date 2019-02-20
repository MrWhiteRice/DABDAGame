﻿using UnityEngine;

public class Bullet : MonoBehaviour
{
	Rigidbody2D rb;
	[SerializeField]
	float speed = 8;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

		Destroy(gameObject, 2);
		rb.velocity = transform.right * speed;
	}

	private void Update()
	{
	}
}
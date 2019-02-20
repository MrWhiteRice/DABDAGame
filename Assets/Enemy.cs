using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	Rigidbody2D rb;

    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
		Vector2 lookDir = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;

		float angle = Mathf.Atan2(lookDir.x, lookDir.y) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.AngleAxis(angle + 90 + 180, Vector3.back);

		rb.velocity = transform.right * 3;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		print("fuck");

		if(collision.transform.CompareTag("Player"))
		{
			collision.transform.GetComponent<Health>().AddHealth(-10);
			Destroy(gameObject);
		}
	}
}
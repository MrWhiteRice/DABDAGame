using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.CompareTag("Player"))
		{
			collision.GetComponent<Health>().AddHealth(10);
			Destroy(gameObject);
		}
	}
}

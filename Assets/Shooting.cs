using UnityEngine;

public class Shooting : MonoBehaviour
{
	[SerializeField]
	Transform shootPoint;

	[SerializeField]
	GameObject bullet;

	void Start()
	{

	}

	void Update()
	{
		Shoot();
	}

	void Shoot()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(bullet, shootPoint.position, shootPoint.rotation);
		}
	}
}

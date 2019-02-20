using UnityEngine;

public class Health : MonoBehaviour
{
	int health = 100;

	void Start()
	{

	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.F))
		{
			health -= 10;
		}
	}

	public int GetHealth()
	{
		return health;
	}
}

using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
	Text health;
	Health playerHealth;

	void Start()
	{
		playerHealth = FindObjectOfType<Health>();
		health = GetComponent<Text>();
	}

    void Update()
    {
		health.text = playerHealth.GetHealth().ToString();
    }
}

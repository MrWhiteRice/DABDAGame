using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
		Vector3 mousePoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

		Vector2 lookDir = mousePoint - transform.position;

		float angle = Mathf.Atan2(lookDir.x, lookDir.y) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.AngleAxis(angle + 90 + 180, Vector3.back);
	}
}
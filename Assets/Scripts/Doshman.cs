using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doshman : MonoBehaviour
{
	public float minRange;
	public float maxRange;
	public float moveSpeed;
	public int direction = 1;

	private void Update()
	{
		Vector2 a = transform.position;
		transform.position = new Vector2(a.x + moveSpeed * direction * Time.deltaTime, a.y);

		if (a.x > maxRange)
		{
			direction = -1;
			GetComponent<SpriteRenderer>().flipX = true;
		}

		if (a.x < minRange)
		{
			direction = 1;
			GetComponent<SpriteRenderer>().flipX = false;
		}
	}
}

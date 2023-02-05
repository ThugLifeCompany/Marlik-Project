using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] private float minRange;
	[SerializeField] private float maxRange;
	[SerializeField] private float moveSpeed;

	private void Update()
	{
		transform.position += Vector3.right * moveSpeed * Time.deltaTime;

		if (transform.localPosition.x > maxRange)
		{
			moveSpeed = -Mathf.Abs(moveSpeed);
			GetComponent<SpriteRenderer>().flipX = true;
		}

		if (transform.localPosition.x < minRange)
		{
			moveSpeed = Mathf.Abs(moveSpeed);
			GetComponent<SpriteRenderer>().flipX = false;
		}
	}
}

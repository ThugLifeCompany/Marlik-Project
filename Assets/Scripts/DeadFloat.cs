using UnityEngine;

public class DeadFloat : MonoBehaviour
{
	private bool playerIsHere;
	private float timer;
	[SerializeField] private float timeToLose;

	private void Update()
	{
		if (playerIsHere)
			timer += Time.deltaTime;

		if (timer >= timeToLose)
			Lose();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		playerIsHere |= other.tag == "Player";
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			playerIsHere = false;
			timer = 0;
		}
	}

	private void Lose()
	{
		//chejuri bebazeh inja benevis
	}
}

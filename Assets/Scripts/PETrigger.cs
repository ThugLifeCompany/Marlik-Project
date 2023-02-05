using UnityEngine;

public enum TriggerAction { KillPlayer, KillEnemy, Win, Lose }

public class PETrigger : MonoBehaviour
{
	[SerializeField] private TriggerAction m_TriggerAction = TriggerAction.KillPlayer;
	[SerializeField] private int timeScale = 1;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			switch (m_TriggerAction)
			{
				case TriggerAction.KillEnemy:
					var rb = other.GetComponent<Rigidbody2D>();
					rb.velocity = new Vector2(rb.velocity.x, 5);
					Destroy(transform.root.gameObject);
					break;
				case TriggerAction.KillPlayer:
					GameObject.Find("GameController").GetComponent<GameController>().Lose(timeScale);
					break;
					case TriggerAction.Win:
					GameObject.Find("GameController").GetComponent<GameController>().Win(timeScale);
					break;
				case TriggerAction.Lose:
					GameObject.Find("GameController").GetComponent<GameController>().Lose(timeScale);
					break;
			}
		}
	}
}

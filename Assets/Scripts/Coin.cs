using UnityEngine;

public class Coin : MonoBehaviour
{
	private void Update()
	{
		transform.Rotate(0, 0.5f, 0);
	}

    private  void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
			GameObject.Find("GameController").GetComponent<GameController>().AddCoin(1);
            Destroy(gameObject);
        }
    }
}

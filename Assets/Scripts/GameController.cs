using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	private int coins;

	//UI
	[SerializeField] private Text WL_Text;
	[SerializeField] private Text coin_Text;
	[SerializeField] private GameObject restartButton;

	private void Start()
	{
		Time.timeScale = 1;
		WL_Text.text = string.Empty;
	}

	private void Update()
	{
		coin_Text.text = "Coins : " + coins;
	}

	public void AddCoin(int count)
	{
		coins += count;
	}

	public void Win(int TimeScale)
	{
		WL_Text.text = "You Win";
		WL_Text.color = Color.green;
		restartButton.SetActive(true);
		Time.timeScale = TimeScale;
	}

	public void Lose(int timeS)
	{
		WL_Text.text = "You Lose";
		WL_Text.color = Color.red;
		restartButton.SetActive(true);
		Time.timeScale = timeS;
	}

	public void Restart()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}
}

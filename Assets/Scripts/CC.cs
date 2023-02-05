using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC : MonoBehaviour
{
	[SerializeField] private Transform player;
	[SerializeField] private Vector3 offset;

	void Update() => transform.position = new Vector3(player.transform.position.x, offset.y, offset.z);
}

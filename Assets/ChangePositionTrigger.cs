using UnityEngine;
using System.Collections;

public class ChangePositionTrigger : MonoBehaviour {

	private GameManager m_GameManager;

	void Awake()
	{
		m_GameManager = GameObject.FindObjectOfType<GameManager>();
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Enemy") {
			m_GameManager.ChangeCameraPostition();
		}

	}

}

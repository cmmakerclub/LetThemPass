using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {

	public float speed = 10.0F;

	public float maxTop = 3.8f;
	public float maxBottom = -3.8f;
	private GameManager m_GameManager;

	void Awake()
	{
		maxTop += transform.position.y;
		maxBottom += transform.position.y;
		m_GameManager = GameObject.FindObjectOfType<GameManager>();
	}

	void Update () 
	{
		float input = Input.GetAxis("Vertical") * speed;
		transform.Translate(0, input, 0);

		if (transform.position.y > maxTop) {
			Vector3 maxBoundary = new Vector3(transform.position.x, maxTop, transform.position.z);
			transform.position = maxBoundary;
		}

		if (transform.position.y < maxBottom) {
			Vector3 maxBoundary = new Vector3(transform.position.x, maxBottom, transform.position.z);
			transform.position = maxBoundary;
		}

	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Enemy") {
			other.gameObject.GetComponent<Copter>().Stop();
			m_GameManager.EndGame();
		}
	}

}

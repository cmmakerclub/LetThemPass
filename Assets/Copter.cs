using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Copter : MonoBehaviour {

	public Transform[] paths;
	public float duration = 5;

	private Vector3[] m_Paths;

	public void Stop()
	{
		Debug.Log("dddd");
		transform.DOKill(false);
		transform.DOLocalMoveY(-10, 3);
	}

	void Start()
	{
		m_Paths = new Vector3[paths.Length];

		for (int i = 0; i < paths.Length; i++) {
			m_Paths[i] = paths[i].position;
		}

		StartRun();
	}

	void StartRun()
	{
		transform.DOPath(m_Paths, duration, PathType.Linear);
	}

}

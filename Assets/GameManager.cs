using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform[] cameraNextPosition;

	public int cameraPositionIndex = 0;

	private Camera m_Camera;

	public void ChangeCameraPostition()
	{
		if (cameraPositionIndex < cameraNextPosition.Length - 1) {
			m_Camera.gameObject.transform.position = cameraNextPosition[++cameraPositionIndex].position;
		}
	}

	public void EndGame()
	{

	}

	public void RestartGame()
	{

	}

	void Awake()
	{
		m_Camera = Camera.main;
		InitCameraPosition();
	}

	void InitCameraPosition()
	{
		m_Camera.gameObject.transform.position = cameraNextPosition[cameraPositionIndex].position;
	}

}

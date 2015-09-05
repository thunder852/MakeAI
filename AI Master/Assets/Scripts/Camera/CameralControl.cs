using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameralControl : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;

	void Start()
	{
		offset = transform.position - target.position;
	}

	void FixedUpdate()
	{
		Vector3 targetCamaeraPosition = target.position + offset;
		//tranform.position = Vector3.Lerp (tranform.position, targetCamaeraPosition, smoothing * Time.deltaTime);
	}
}

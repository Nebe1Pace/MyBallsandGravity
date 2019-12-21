using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy : MonoBehaviour
{
	public Transform aroundPoint;
	public float circleInSecond = 0.75f;
    public float offsetSin = 1.25f; 
	public float offsetCos = 1.25f; 
    float dist;
	float circleRadians = Mathf.PI;
	float currentAng = 0;
    void Start()
	{
		dist = (transform.position - aroundPoint.position).magnitude;
	}
    void Update()
	{
		Vector3 p = aroundPoint.position;
		p.x += Mathf.Sin(currentAng) * dist * offsetSin;
		p.z += Mathf.Cos(currentAng) * dist * offsetCos;
		transform.position = p;
		currentAng += circleRadians * circleInSecond * Time.deltaTime;
	}
}
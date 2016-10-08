using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewRotator : MonoBehaviour
{
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.localEulerAngles += Vector3.up * 0.01f;
	}
}

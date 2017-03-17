using UnityEngine;
using System.Collections;

public class TestRotate : MonoBehaviour {
	float rad;

	// Use this for initialization
	void Start () {
		rad = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,1,0);
	}
}

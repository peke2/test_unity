using UnityEngine;
using System.Collections;

public class VectorRefrection : MonoBehaviour {
	public Vector3 direction;
	public float length;

	LineRenderer line;
	LineRenderer outRay;


	Vector3 endPos;
	Vector3 refrectNormal;

	void Awake()
	{
		line = GetComponent<LineRenderer>();
		endPos = transform.position;
	
		GameObject obj = GameObject.Find("OutRay");
		outRay = obj.GetComponent<LineRenderer>();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 startPos = transform.position;

		line.SetPosition(0, startPos);
		//line.SetPosition(1, transform.position + direction*length);
		line.SetPosition(1, endPos);

		Vector3 v = endPos - startPos;
		float n = Vector3.Dot(refrectNormal, v);
		Vector3 outRayLine = -2 * n * refrectNormal + v;
		outRay.SetPosition(0, endPos);
		outRay.SetPosition(1, outRayLine+endPos);
	}

	public void setHitPoint(Vector3 hitPos, Vector3 hitNormal)
	{
		endPos = hitPos;
		refrectNormal = hitNormal;
	}
}

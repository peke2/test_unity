using UnityEngine;
using System.Collections;

public class Interrupt : MonoBehaviour {
	public GameObject vectorRefrection;

	void Awake()
	{
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		VectorRefrection vref = vectorRefrection.GetComponent<VectorRefrection>();
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		RaycastHit	hit;
		if( Physics.Raycast(ray, out hit, 100) )
		{
			vref.setHitPoint(hit.point, hit.normal);
		}
	}
}

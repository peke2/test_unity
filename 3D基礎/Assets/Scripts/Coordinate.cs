using UnityEngine;
using System.Collections;

public class Coordinate : MonoBehaviour {
	GameObject objWorld;
	GameObject objHouse;
	GameObject objCar;

	bool isRotateWorld;
	bool isRotateHouse;
	bool isRotateCar;


	void Awake()
	{
		objWorld = GameObject.Find("World");
		objHouse = GameObject.Find("House");
		objCar = GameObject.Find("Car");
		isRotateWorld = false;
		isRotateHouse = false;
		isRotateCar = false;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( true == isRotateWorld )
		{
			objWorld.transform.Rotate(new Vector3(0,1,0), 1f);
		}
		if( true == isRotateHouse )
		{
			objHouse.transform.Rotate(new Vector3(0,1,0), -1.5f);
		}
		if( true == isRotateCar )
		{
			objCar.transform.Rotate(new Vector3(0,1,0), 2f);
		}
	}

	public void OnValueChanged(Object obj)
	{
		if( obj.name == "RotateModel" )
		{
			isRotateHouse = !isRotateHouse;
			isRotateCar = !isRotateCar;
			return;
		}

		if( obj.name == "RotateWorld" )
		{
			isRotateWorld = !isRotateWorld;
			return;
		}
	}
}

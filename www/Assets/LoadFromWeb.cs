﻿using UnityEngine;
using System.Collections;

public class LoadFromWeb : MonoBehaviour {
	public string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";

	IEnumerator Start () {
		WWW www = new WWW(url);
		yield return www;
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = www.texture;
	}
	
	void Update () {
	
	}
}

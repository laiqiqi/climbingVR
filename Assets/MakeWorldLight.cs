﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWorldLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        RenderSettings.ambientIntensity = 1f;
    }
}

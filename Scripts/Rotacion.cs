﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		//Este codigo permite a los picks ups girar en el mismo punto
		
		transform.Rotate( new Vector3(15, 30, 45) * Time.deltaTime);
	}
}

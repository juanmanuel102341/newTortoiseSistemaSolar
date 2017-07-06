using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour {
	
	public  float velocity_rotacion;
	void Update () {
		
		transform.Rotate(0,velocity_rotacion,0);

	}
}

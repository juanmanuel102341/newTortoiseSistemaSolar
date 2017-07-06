using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslacion : MonoBehaviour {


	public Transform target;
	public float angel;
	// Update is called once per frame
	void Update () {
		transform.RotateAround(target.position,Vector3.up,angel);

	}
}

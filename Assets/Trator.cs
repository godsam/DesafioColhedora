using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trator : MonoBehaviour {

	public float velocidade = 5;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.MovePosition (transform.position + transform.forward * velocidade * Time.deltaTime); 
	}
}

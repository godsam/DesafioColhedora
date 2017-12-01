using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trator : MonoBehaviour {

	public float velocidade = 5;
	Vector3 nextPos;
	Vector3 direcao;
	float distancia = 0;
	Rigidbody rb;

	GameObject[] targets;
	int i = 0;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		targets = GameObject.FindGameObjectsWithTag ("Pega");
		nextPos = targets [i].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		distancia = Vector3.Distance (transform.position, nextPos);
		if (distancia < 0.9f) {
			i++;
			if (i >= targets.Length) {
				i = 0;
			}
			nextPos = targets [i].transform.position;
		}

		direcao = (nextPos - transform.position).normalized;
		rb.MovePosition (transform.position + direcao * velocidade * Time.deltaTime); 
	}
}

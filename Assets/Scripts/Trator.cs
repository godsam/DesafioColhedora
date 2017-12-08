using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trator : MonoBehaviour {

	public float velocidade = 5;
	Vector3 nextPos;
	Vector3 direcao;
	float distancia = 0;
	Rigidbody rb;

	public GameObject T1, T2, T3, T4, T5, T6, T7, T8;

	int i = 1;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (i) {
		case 1:
			nextPos = T1.transform.position;
			break;
		case 2:
			nextPos = T2.transform.position;
			break;
		case 3:
			nextPos = T3.transform.position;
			break;
		case 4:
			nextPos = T4.transform.position;
			break;
		case 5:
			nextPos = T5.transform.position;
			break;
		case 6:
			nextPos = T6.transform.position;
			break;
		case 7:
			nextPos = T7.transform.position;
			break;
		case 8:
			nextPos = T8.transform.position;
			break;
		}

		distancia = Vector3.Distance (transform.position, nextPos);
		direcao = (nextPos - transform.position).normalized;
		rb.MovePosition (transform.position + direcao * velocidade * Time.deltaTime); 

		if (distancia < 0.9f) {
			i++;
			if (i == 9) {
				i = 1;
			}
		}
	}
}

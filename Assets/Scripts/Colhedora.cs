using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colhedora : MonoBehaviour {

	public terreno terreno;

	bool areaDeColeta;
	float distancia = 0;
	int nI = 0;

	Vector3 pA,pB,pC,pD;
	// Use this for initialization
	void Start () {
		pA = terreno.pA;
		pB = terreno.pB;
		pC = terreno.pC;
		pD = terreno.pD;
	}
	
	// Update is called once per frame
	void Update () {
		distancia = distancia + transform.forward.x * Time.deltaTime;

		areaDeColeta = (pA.x < transform.position.x && pA.z > transform.position.z);
		areaDeColeta = (areaDeColeta && pB.x > transform.position.x && pB.z > transform.position.z);
		areaDeColeta = (areaDeColeta && pC.x < transform.position.x && pC.z < transform.position.z);
		areaDeColeta = (areaDeColeta && pD.x > transform.position.x && pD.z < transform.position.z);

		if (distancia > 1) {
			distancia = 0;
		}

		if (areaDeColeta && distancia == 0) {
			nI++;
			print ("entrou na area e contou a distancia " + nI);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terreno : MonoBehaviour {

	public Vector3 pA;
	public Vector3 pB;
	public Vector3 pC;
	public Vector3 pD;

	public Vector3 pA1;
	public Vector3 pB1;
	public Vector3 pC1;
	public Vector3 pD1;

	public Vector3 pA2;
	public Vector3 pB2;
	public Vector3 pC2;
	public Vector3 pD2;

	public Vector3 pA3;
	public Vector3 pB3;
	public Vector3 pC3;
	public Vector3 pD3;

	public GameObject ponto1,ponto2,ponto3,ponto4;
	// Use this for initialization
	void Start () {
		Instantiate (ponto1, pA,transform.rotation);

		Instantiate (ponto1, pB,transform.rotation);

		Instantiate (ponto1, pC,transform.rotation);

		Instantiate (ponto1, pD,transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

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

		Instantiate (ponto2, pA1,transform.rotation);

		Instantiate (ponto2, pB1,transform.rotation);

		Instantiate (ponto2, pC1,transform.rotation);

		Instantiate (ponto2, pD1,transform.rotation);

		Instantiate (ponto3, pA2,transform.rotation);

		Instantiate (ponto3, pB2,transform.rotation);

		Instantiate (ponto3, pC2,transform.rotation);

		Instantiate (ponto3, pD2,transform.rotation);

		Instantiate (ponto4, pA3,transform.rotation);

		Instantiate (ponto4, pB3,transform.rotation);

		Instantiate (ponto4, pC3,transform.rotation);

		Instantiate (ponto4, pD3,transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

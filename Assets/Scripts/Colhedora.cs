using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colhedora : MonoBehaviour {

	public terreno terreno;
	public Text dados;

	bool areaDeColetaA;
	bool areaDeColetaB;
	bool areaDeColetaC;
	bool areaDeColetaD;
	float distancia = 0;
	int nA,nB,nC,nD = 0;
	int coleta, nMin, nMax, variacao, acumulado = 0;
	int acuA, acuB, acuC, acuD = 0;

	Vector3 pA1,pB1,pC1,pD1;
	Vector3 pA2,pB2,pC2,pD2;
	Vector3 pA3,pB3,pC3,pD3;
	Vector3 pA4,pB4,pC4,pD4;

	// Use this for initialization
	void Start () {
		pA1 = terreno.pA;
		pB1 = terreno.pB;
		pC1 = terreno.pC;
		pD1 = terreno.pD;

		pA2 = terreno.pA1;
		pB2 = terreno.pB1;
		pC2 = terreno.pC1;
		pD2 = terreno.pD1;

		pA3 = terreno.pA2;
		pB3 = terreno.pB2;
		pC3 = terreno.pC2;
		pD3 = terreno.pD2;

		pA4 = terreno.pA3;
		pB4 = terreno.pB3;
		pC4 = terreno.pC3;
		pD4 = terreno.pD3;
	}
	
	// Update is called once per frame
	void Update () {
		// Verificação se entrou na area de valor 30 - 60
		areaDeColetaD = (pA4.x < transform.position.x && pA4.z > transform.position.z); 
		areaDeColetaD = (areaDeColetaD && pB4.x > transform.position.x && pB4.z > transform.position.z);
		areaDeColetaD = (areaDeColetaD && pC4.x < transform.position.x && pC4.z < transform.position.z);
		areaDeColetaD = (areaDeColetaD && pD4.x > transform.position.x && pD4.z < transform.position.z);

		// Verificação se entrou na area de valor 30 - 45
		areaDeColetaC = (pA3.x < transform.position.x && pA3.z > transform.position.z); 
		areaDeColetaC = (areaDeColetaC && pB3.x > transform.position.x && pB3.z > transform.position.z);
		areaDeColetaC = (areaDeColetaC && pC3.x < transform.position.x && pC3.z < transform.position.z);
		areaDeColetaC = (areaDeColetaC && pD3.x > transform.position.x && pD3.z < transform.position.z);

		// Verificação se entrou na area de valor 15 - 30
		areaDeColetaB = (pA2.x < transform.position.x && pA2.z > transform.position.z); 
		areaDeColetaB = (areaDeColetaB && pB2.x > transform.position.x && pB2.z > transform.position.z);
		areaDeColetaB = (areaDeColetaB && pC2.x < transform.position.x && pC2.z < transform.position.z);
		areaDeColetaB = (areaDeColetaB && pD2.x > transform.position.x && pD2.z < transform.position.z);

		// Verificação se entrou na area de valor 5 - 15
		areaDeColetaA = (pA1.x < transform.position.x && pA1.z > transform.position.z);
		areaDeColetaA = (areaDeColetaA && pB1.x > transform.position.x && pB1.z > transform.position.z);
		areaDeColetaA = (areaDeColetaA && pC1.x < transform.position.x && pC1.z < transform.position.z);
		areaDeColetaA = (areaDeColetaA && pD1.x > transform.position.x && pD1.z < transform.position.z);

		if (areaDeColetaA || areaDeColetaB || areaDeColetaC || areaDeColetaD) {
			// Adição de distância
			distancia = distancia + transform.forward.x * Time.deltaTime;
		}

		// Quando a distância maior que 1 (10) reinicia a contagem
		if (distancia > 1) {
			distancia = 0;
		}

		// Quando a distância for igual a zero, registra a coleta
		if (distancia == 0) {
			if (areaDeColetaD) {
				nD++;
				print ("entrou na area 4 e contou a distância " + nD);
				PegaColeta (4);
			} else if (areaDeColetaC) {
				nC++;
				print ("entrou na area 3 e contou a distância " + nC);
				PegaColeta (3);
			} else if (areaDeColetaB) {
				nB++;
				print ("entrou na area 2 e contou a distância " + nB);
				PegaColeta (2);
			} else if (areaDeColetaA) {
				nA++;
				print ("entrou na area 1 e contou a distância " + nA);
				PegaColeta (1);
			}
		}
	}

	void PegaColeta(int n)
	{
		if (n == 1) {
			// Valor 5 - 15
			DefineRange(coleta, 5, 15, 2, (coleta > 15 || coleta < 5));

			coleta = Random.Range(nMin,nMax);
			acumulado += coleta;
			acuA += coleta;
			dados.text = "[Area de coleta A - " + "Dado coletado: " + coleta.ToString() + "] - Acumulado: " + acumulado.ToString() + " - A: " + acuA.ToString() + " B: " + acuB.ToString() + " C: " + acuC.ToString() + " D: " + acuD.ToString();
		} else if (n == 2) {
			// Valor 15 - 30
			DefineRange(coleta, 15, 30, 3, (coleta > 30 || coleta < 15));

			coleta = Random.Range(nMin,nMax);
			acumulado += coleta;
			acuB += coleta;
			dados.text = "[Area de coleta B - " + "Dado coletado: " + coleta.ToString() + "] - Acumulado: " + acumulado.ToString() + " - A: " + acuA.ToString() + " B: " + acuB.ToString() + " C: " + acuC.ToString() + " D: " + acuD.ToString();
		} else if (n == 3) {
			// Valor 30 - 45
			DefineRange(coleta, 30, 45, 4, (coleta > 45 || coleta < 30));

			coleta = Random.Range(nMin,nMax);
			acumulado += coleta;
			acuC += coleta;
			dados.text = "[Area de coleta C - " + "Dado coletado: " + coleta.ToString() + "] - Acumulado: " + acumulado.ToString() + " - A: " + acuA.ToString() + " B: " + acuB.ToString() + " C: " + acuC.ToString() + " D: " + acuD.ToString();
		} else if (n == 4) {
			// Valor 30 - 60
			DefineRange(coleta, 30, 60, 5, (coleta > 60 || coleta < 30));

			coleta = Random.Range(nMin,nMax);
			acumulado += coleta;
			acuD += coleta;
			dados.text = "[Area de coleta D - " + "Dado coletado: " + coleta.ToString() + "] - Acumulado: " + acumulado.ToString() + " - A: " + acuA.ToString() + " B: " + acuB.ToString() + " C: " + acuC.ToString() + " D: " + acuD.ToString();
		}
	}

	void DefineRange (int c, int nD, int nU, int v, bool restaura)
	{
		nMin = c - v;
		nMax = c + nU;

		if (nMin < nD || restaura) {
			nMin = nD;
		}

		if (nMax > nU || restaura) {
			nMax = nU;
		}
	}
}

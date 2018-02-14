using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_obstaculos : MonoBehaviour {

	public GameObject[] obstaculos;
	public float segundos;
	float segundos_actuales;

	// Use this for initialization
	void Start () {
		segundos_actuales = segundos;
		
	}
	
	// Update is called once per frame
	void Update () {
		segundos_actuales -= Time.deltaTime;
		if (segundos_actuales <= 0.0f) {
			//CREAR OBJETO 
			print("objeto nuevo añadido nuevo obstáculo");
			Instantiate (obstaculos [Random.Range (0, obstaculos.Length)],
				transform.position = new Vector3 (Random.Range (-6.0f, 6.0f), -14, 0),transform.rotation);
			segundos_actuales = segundos;

		}
	}
}

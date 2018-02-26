using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_obstaculos : MonoBehaviour {

	public GameObject[] obstaculos;
	public float X;
	public float Y;
	public float segundos;
	float segundos_actuales;

	// Use this for initialization
	void Start () {
		segundos_actuales = segundos;
		
	}
	
	// Update is called once per frame
	void Update () {
		//empieza restando el tiempo actual
		segundos_actuales -= Time.deltaTime;

		//
		if (segundos_actuales <= 0.0f) {
			//CREAR OBJETO 
			print("objeto nuevo añadido nuevo obstáculo");
			Instantiate (obstaculos [Random.Range (0, obstaculos.Length)],
				transform.position = new Vector2 (X,Y),transform.rotation);
			segundos_actuales = Random.Range(1,segundos);

		}
	}
}

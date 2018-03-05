using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gen_Barriles : MonoBehaviour {

	public GameObject[] obstaculos;
	public float segundos = 15;
	float segundos_actuales;

	Vector2[] puntos = new Vector2[] { 
		new Vector2(-5.97f,4.58f),
		new Vector2(-5.97f,1.47f),
		new Vector2(-5.97f,-1.72f),
		new Vector2(-5.97f,-4.6f),
		new Vector2(0.74f,4.58f),
		new Vector2(0.74f,1.47f),
		new Vector2(0.64f,-1.72f),
		new Vector2(0.74f,-4.6f),
		new Vector2(6.11f,4.58f),
		new Vector2(6.11f,1.47f),
		new Vector2(6.11f,-1.72f),
		new Vector2(6.21f,-4.6f),

	};



	// Use this for initialization
	void Start () {
		segundos_actuales = segundos;
		
	}
	
	// Update is called once per frame
	void Update () {
		//empieza restando el tiempo actual
		segundos_actuales -= Time.deltaTime;

		//cuando los segundos sean 0,
		//en un punto aleatorio, 
		//instancia un obstaculo (barril o herramienta)
		if (segundos_actuales <= 0.0f) {

			Vector2 dondeGenero = puntos [Random.Range (0, puntos.Length)];
			//CREAR OBJETO 
			//print("objeto nuevo añadido nuevo obstáculo");
			Instantiate (obstaculos [Random.Range (0, obstaculos.Length)],
				transform.position = dondeGenero,transform.rotation);
			segundos_actuales = segundos;

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_tiros : MonoBehaviour {

	public GameObject tiro;
	//public float segundos;


	// Use this for initialization
	void Start () {
		//segundos_actuales = segundos;
		
	}
	
	// Update is called once per frame
	void Update () {
		//empieza restando el tiempo actual
		//segundos_actuales -= Time.deltaTime;

		//
		if (Input.GetKeyDown("space")) {
			//CREAR OBJETO 





			Instantiate (tiro,
				transform.position,transform.rotation);
			//segundos_actuales = Random.Range(1,segundos);

		}
	}
}

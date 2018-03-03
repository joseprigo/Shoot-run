/**
 *
 *
 *
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bandidito_controller : MonoBehaviour {
	public float force;
	Vector3 posini;
	public GameObject Scenecontroller;
	Scene_controler sc;
	float rotacioini;



	// Use this for initialization
	void Start () {



		posini = transform.position;
		rotacioini = gameObject.GetComponent<Rigidbody2D> ().rotation;

	}
	
	// Update is called once per frame
	void Update () {
		float moveHor = Input.GetAxis ("Horizontal"); //preguntar si hay algún movimiento en el eje horizontal




		float moveVer = Input.GetAxis ("Vertical"); //preguntar si hay algún movimiento en el eje vertical
		if(moveHor != 0 || moveVer != 0 ){
			Vector2 vectorDir = new Vector2 (moveHor * Time.deltaTime * force, moveVer * Time.deltaTime * force);

			gameObject.GetComponent<Rigidbody2D> ().AddForce(vectorDir);

			float rot = Math.Atan2( (double)(moveHor * Time.deltaTime),(double)(moveVer * Time.deltaTime * force));
		}
		/*
		print (moveVer);
		if (moveHor < 0 && rotacioini!=90.00) {
			print (moveHor);
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (90);
			rotacioini = 90.00f;
		} else if (moveHor > 0  && rotacioini!=270.00) {
			rotacioini = 270.00f;
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (270);
		} else if (moveVer < 0  && rotacioini!=180.00) {
			rotacioini = 180.00f;
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (180);
		} else if (moveVer > 0  && rotacioini!=0.00) {
			rotacioini = 0.00f;
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (0);
		}*/




	}
	/**void OnTriggerEnter2D(Collider2D other){
		print ("ME HAS TOCADO");
		transform.position = posini;
		gameObject.GetComponent<Rigidbody2D> ().velocity = velini;
		//sc.OnDie ();
	}*/
}

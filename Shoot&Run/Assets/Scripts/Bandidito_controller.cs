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
	//Vector3 posini;
	public GameObject Scenecontroller;
	Scene_controler sc;

	float moveHor = 0.00f;
	float moveVer = 0.00f;



	// Use this for initialization
	void Start () {



	

	}
	
	// Update is called once per frame
	void Update () {


		moveHor = Input.GetAxis ("Horizontal"); //preguntar si hay algún movimiento en el eje horizontal



		 moveVer = Input.GetAxis ("Vertical"); //preguntar si hay algún movimiento en el eje vertical

		Vector2 fuerza = new Vector2(moveHor * Time.deltaTime * force, moveVer * Time.deltaTime * force);

		gameObject.GetComponent<Rigidbody2D> ().AddForce(fuerza);


		/**
		 * Rotación
		 * como se puede leer en el foro, el codigo está pensado para mover un objeto que se encuantra mirando
		 * hacia, así que al calcular el ángulo le he restado 90 grados (no soy 100tifiko)
		 * fuente: https://answers.unity.com/questions/630670/rotate-2d-sprite-towards-moving-direction.html 
		 */
		Vector2 moveDirection = gameObject.GetComponent<Rigidbody2D>().velocity;
		if (moveDirection != Vector2.zero) {
			float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg-90;

			transform.rotation = Quaternion.AngleAxis(angle, new Vector3(0.0f, 0.0f, 100000.0f));
		}


		//transform.rotation = Quaternion.LookRotation(gameObject.GetComponent<Rigidbody2D> ().velocity);




		/**if(moveHor != 0 || moveVer != 0 ){
			Vector2 vectorDir = new Vector2 (moveHor * Time.deltaTime * force, moveVer * Time.deltaTime * force);


			gameObject.GetComponent<Rigidbody2D> ().AddForce(vectorDir);



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

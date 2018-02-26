/**
 *
 *
 *
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandidito_controller : MonoBehaviour {
	public float force;
	Vector3 posini;
	Vector2 velini;
	public GameObject Scenecontroller;
	Scene_controler sc;
	float rotacioini;



	// Use this for initialization
	void Start () {



		posini = transform.position;
		velini = gameObject.GetComponent<Rigidbody2D> ().velocity;
		rotacioini = gameObject.GetComponent<Rigidbody2D> ().rotation;

	}
	
	// Update is called once per frame
	void Update () {
		float moveHor = Input.GetAxis ("Horizontal"); //preguntar si hay algún movimiento en el eje horizontal
		gameObject.GetComponent<Rigidbody2D> ().AddForce(new Vector2(moveHor * Time.deltaTime * force, 0.0f));




		float moveVer = Input.GetAxis ("Vertical"); //preguntar si hay algún movimiento en el eje vertical


	
		if (moveHor < 0 && rotacioini!=90.00) {
			print (moveHor);
			print ("Anar a l'esquerra");
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (90);
			rotacioini = 90.00f;
		} else if (moveHor > 0  && rotacioini!=270.00) {
			print ("Anar a la dreta");
			rotacioini = 270.00f;
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (270);
		} else if (moveVer < 0  && rotacioini!=180.00) {
			print ("Anar a cap abaix");
			rotacioini = 180.00f;
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (180);
		} else if (moveVer > 0  && rotacioini!=0.00) {
			print ("Anar a a dalt");
			rotacioini = 0.00f;
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (0);
		}



		gameObject.GetComponent<Rigidbody2D> ().AddForce(new Vector2(0.0f,moveVer * Time.deltaTime * force));
	}
	/**void OnTriggerEnter2D(Collider2D other){
		print ("ME HAS TOCADO");
		transform.position = posini;
		gameObject.GetComponent<Rigidbody2D> ().velocity = velini;
		//sc.OnDie ();
	}*/
}

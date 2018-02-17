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

	int direccion; // 0-> arriba, 1->abajo, 2->derecha, 3-> izquierda


	// Use this for initialization
	void Start () {

		direccion = 0;

		posini = transform.position;
		velini = gameObject.GetComponent<Rigidbody2D> ().velocity;

	}
	
	// Update is called once per frame
	void Update () {
		float moveHor = Input.GetAxis ("Horizontal"); //preguntar si hay algún movimiento en el eje horizontal
		gameObject.GetComponent<Rigidbody2D> ().AddForce(new Vector2(moveHor * Time.deltaTime * force, 0.0f));




		float moveVer = Input.GetAxis ("Vertical"); //preguntar si hay algún movimiento en el eje vertical


	
		if (moveHor < 0) {
			print ("Anar a l'esquerra");
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (90);
			direccion = 3;
		} else if (moveHor > 0) {
			print ("Anar a la dreta");
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (270);
			direccion = 0;
		} else if (moveVer < 0) {
			print ("Anar a cap abaix");
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (180);
			direccion = 3;
		} else if (moveVer > 0) {
			print ("Anar a a dalt");
			gameObject.GetComponent<Rigidbody2D> ().MoveRotation (0);
			direccion = 0;
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

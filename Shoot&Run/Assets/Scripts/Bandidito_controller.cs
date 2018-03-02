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
	public GameObject Scenecontroller;
	Scene_controler sc;
	float rotacioini;
	float moveHor = 0.00f;
	float moveVer = 0.00f;



	// Use this for initialization
	void Start () {



		rotacioini = gameObject.GetComponent<Rigidbody2D> ().rotation;

	}
	
	// Update is called once per frame
	void Update () {
		moveHor = Input.GetAxis ("Horizontal"); //preguntar si hay algún movimiento en el eje horizontal


		moveVer = Input.GetAxis ("Vertical"); //preguntar si hay algún movimiento en el eje vertical

		Vector2 fuerza = new Vector2(moveHor * Time.deltaTime * force, moveVer * Time.deltaTime * force);

		gameObject.GetComponent<Rigidbody2D> ().AddForce(fuerza);

		transform.rotation;




	}
	/**void OnTriggerEnter2D(Collider2D other){
		print ("ME HAS TOCADO");
		transform.position = posini;
		gameObject.GetComponent<Rigidbody2D> ().velocity = velini;
		//sc.OnDie ();
	}*/
}

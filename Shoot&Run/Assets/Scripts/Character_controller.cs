using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_controller : MonoBehaviour {
	public float force;
	Vector3 posini;
	Vector2 velini;
	public GameObject Scenecontroller;
	Scene_controler sc;

	// Use this for initialization
	void Start () {
		posini = transform.position;
		velini = gameObject.GetComponent<Rigidbody2D> ().velocity;

	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis ("Horizontal"); //preguntar si hay algún movimiento en el eje horizontal
		gameObject.GetComponent<Rigidbody2D> ().AddForce(new Vector2(move * Time.deltaTime* force, 0.0f));
	}
	void OnTriggerEnter2D(Collider2D other){
		print ("ME HAS TOCADO");
		transform.position = posini;
		gameObject.GetComponent<Rigidbody2D> ().velocity = velini;
		//sc.OnDie ();
	}
}

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

	public GameObject Scenecontroller;
	Scene_controler sc;

	//obtenemos metodos del Scene_controler para bajar la vida al chocar con un coche
	private Estado_juego EstadoJuego; 

	float moveHor = 0.00f;
	float moveVer = 0.00f;



	// Use this for initialization
	void Start () {
		// se obtiene el script del Estado del juego
		EstadoJuego = Scene_controler.ObtenerComponente<Estado_juego> ("Scene_controller");


	

	}
	
	// Update is called once per frame
	void Update () {


		moveHor = Input.GetAxis ("Horizontal"); //preguntar si hay algún movimiento en el eje horizontal



		 moveVer = Input.GetAxis ("Vertical"); //preguntar si hay algún movimiento en el eje vertical

		Vector2 fuerza = new Vector2(moveHor * Time.deltaTime * force, moveVer * Time.deltaTime * force);

		gameObject.GetComponent<Rigidbody2D> ().AddForce(fuerza);

		//si hay movimento de juego bajar la gasolina
		float desgasteHor = Math.Abs(moveHor);
		float desgasteVer = Math.Abs (moveVer);
		EstadoJuego.gasolina -=  desgasteHor/100.0f + desgasteVer/100.0f;


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

	}
	// bandidito se encuentra con un barril de gasolina
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Barril") {
			Destroy (other.gameObject);
			EstadoJuego.repostarGas();


		}
		//bandidito se encuentra con una herramienta de reparacion
		if (other.gameObject.tag == "RepairTool") {
			Destroy (other.gameObject);

			//con el script que hemos obtenido, llamamos a la función chocar, que baja la vida al jugador
			EstadoJuego.repararBandidito ();

		}

	}
}

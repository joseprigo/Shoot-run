using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_movement : MonoBehaviour
{

    public float speed;
	public GameObject explosion;
	//obtenemos metodos del Scene_controler para bajar la vida al chocar con un coche
	private Estado_juego EstadoJuego; 
    void Start()
    {
		// se obtiene el script del Estado del juego
		EstadoJuego = Scene_controler.ObtenerComponente<Estado_juego> ("Scene_controller");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            transform.position.y + speed * Time.deltaTime,
            transform.position.z);
    }
	//el coche "choca" con una bala
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "balaTag") {
			Instantiate (explosion,
				transform.position,transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);

			
		}
		// el coche choca con el jugador
		if (other.gameObject.tag == "playerTag") {
			Instantiate (explosion,
				transform.position,transform.rotation);
			Destroy (gameObject);

			//con el script que hemos obtenido, llamamos a la función chocar, que baja la vida al jugador
			EstadoJuego.chocar ();

		}

	}

}


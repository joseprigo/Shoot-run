using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_controler : MonoBehaviour {
	
	public AudioClip disparo;
	AudioSource sonido;


	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			sonido.PlayOneShot (disparo);
		}
	}

	public void OnDie(){
		print ("muerto");
		Application.Quit ();
		//CUIDAO, A CONTINUACIÓN HAY LA LINIA PARA SALIR DEL TEST EN EL MODO EDICION
		//UnityEditor.EditorApplication.isPlaying =false;
	}


	/**
	 * 
	 * Para poder acceder a estas funciones desde otros scripts
	 * @param T nombre del script
	 * @param nombreObjeto String nombre del objeto de unity en el que se encuentra el script
	 * @returns un script del juego, por ejemplo el Estado_juego
	 */
	public static T ObtenerComponente<T>(string nombreObjeto) where T: UnityEngine.Component{
		GameObject controlador = GameObject.Find (nombreObjeto);
		if (controlador != null) {
			return controlador.GetComponent<T> ();
		} else {
			Debug.LogError ("no existe el GameObject " + nombreObjeto);
			return null;
		}
	}
}

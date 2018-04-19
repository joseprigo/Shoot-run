using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manzana : MonoBehaviour {

	public GameObject drawnExplosion;
	public AudioClip impacto;
	AudioSource sonido;
	private bool boolean;

	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if ( other.gameObject.tag == "balaTag") {
			Instantiate (drawnExplosion,
				other.transform.position,other.transform.rotation);
			Destroy (other.gameObject);
			sonido.PlayOneShot (impacto);
		}
	}
}

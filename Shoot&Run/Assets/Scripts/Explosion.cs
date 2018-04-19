using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

	public AudioClip explosionSound;
	AudioSource sonido;
	float segundos = 1.50f;
    // Use this for initialization
    void Start()
	{
		sonido = GetComponent<AudioSource> ();
		sonido.PlayOneShot (explosionSound);
		Destroy (gameObject, segundos);
    }

    // Update is called once per frame
    void Update()
    {
    }

}


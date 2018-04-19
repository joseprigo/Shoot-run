using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilScript : MonoBehaviour
{

	public float segundos;
	float mediosegundo =0.25f;
    // Use this for initialization
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {

		segundos-= Time.deltaTime;

		//cuando falten 5.0 segundos para desaparecer, el barril empieza a parpadear
		if (segundos >= 0.0f && segundos <= 5.0f) {
			mediosegundo -= Time.deltaTime;
			if (mediosegundo <= 0.0f) {
				toggle ();
				mediosegundo =0.25f;
			}
		} 
		if (segundos < 0.0f) {
			print ("Recogida de objeto: tiempo agotado");
			Destroy (gameObject);
		}

    }
	/**
	 * oculta /muestra el barril
	 */
	private void toggle(){
		if (GetComponent<Renderer> ().enabled) {
			GetComponent<Renderer> ().enabled = false;
		} else {
			GetComponent<Renderer> ().enabled = true;
		}
	}


}


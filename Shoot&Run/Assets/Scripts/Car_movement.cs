using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_movement : MonoBehaviour
{

    public float speed;
	public GameObject explosion;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            transform.position.y + speed * Time.deltaTime,
            transform.position.z);
    }
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "balaTag") {
			Instantiate (explosion,
				transform.position,transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);

			
		}
		if (other.gameObject.tag == "playerTag") {
			Instantiate (explosion,
				transform.position,transform.rotation);
			Destroy (gameObject);

		}

	}

}


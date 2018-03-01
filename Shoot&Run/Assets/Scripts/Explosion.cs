using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

	float segundos = 0.50f;
    // Use this for initialization
    void Start()
    {
		Destroy (gameObject, segundos);
    }

    // Update is called once per frame
    void Update()
    {

    }

}


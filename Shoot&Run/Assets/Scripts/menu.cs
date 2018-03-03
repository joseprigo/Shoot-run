using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization

	//función que se activa al hacer click con el ratón en el elemento que posee este script
	void OnMouseDown () {
	//Cargamos la escena que esté inmediatamente a continuación de la escena en la que se ejecute este script
	SceneManager.LoadScene (1);
	}


	}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estado_juego : MonoBehaviour {
	public int vidaInicial = 100;
	public float gasolinaInicial = 100.0f;
	public int vida;
	public float gasolina;
	private Scene_controler Scene; //obtener las funciones del Scene_controler.cs
	private Text_controller Text; //obtener las funciones del Text_controler.cs
	private const float MAX_GAS = 200.0f;
	private const int MAX_VIDA = 100;


	int tiempo = 0;
	float periodoGasolina = 5;

	void Start () {
		Scene = Scene_controler.ObtenerComponente<Scene_controler> ("Scene_controller"); //inicializar las funciones de la escena
		Text = Scene_controler.ObtenerComponente<Text_controller>("Scene_controller");
		vida = vidaInicial;

		gasolina = gasolinaInicial;
		Text.setEST (vida);
	}
	
	// Update is called once per frame
	void Update () {
		//tiempo trancurrido en el juego
		tiempo += (int) (Time.deltaTime*100.0f);
		print (Time.deltaTime);
		Text.setTmp (tiempo);

		//Cada 5 segundos se baja la gasolina aunque no haya movimiento
		periodoGasolina-= Time.deltaTime;
		Text.setGAS (gasolina);
		if (periodoGasolina <= 0.0f) {
			gasolina--;
			periodoGasolina = 5;
		}

		if (gasolina == 10.0f) {
			print ("Gasolina: nivel Bajo");
		}

		//fin de la gasolina
		if (gasolina <= 0.0f){
			Scene.OnDie ();
		}
	}

	/**
	 * Funciones del estado del juego de nombre autoexplicativo
	 * -chocar
	 * -repostarGas
	 * -repararBandidito
	 */
	public void chocar(){
		
		if (vida > 0) {
			vida-= 10;
			Text.setEST (vida);
			print ("Chocar: " + vida); 
		}
		if (vida <= 0) {
			Scene.OnDie ();


		}
	}

	public void repostarGas(){
		gasolina+= 25.0f;
		if (gasolina > MAX_GAS) {
			gasolina = MAX_GAS;
		}
		Text.setGAS (gasolina);
		print ("Repostando: " + gasolina); 
	}

	public void repararBandidito(){
		vida += 45;
		if (vida > MAX_VIDA) {
			vida = MAX_VIDA;
		}
		Text.setEST (vida);
		print ("Reparación: " + vida);
	}

}

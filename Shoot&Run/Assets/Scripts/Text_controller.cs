using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
/**
 * Script Para mostrar las Variables al jugado
 * 
 *  las variables del juego se convierten a textos Canvas
 * 
 */

public class Text_controller : MonoBehaviour {

	public Text textGas;
	public Text textEst;
	public Text textTmp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setGAS(float gasF){
		
		textGas.text = gasF.ToString("000");
	}

	public void setEST (int estI){
		textEst.text = estI.ToString();
	}

	public void setTmp (int tiempo){
		int Horas = tiempo / 3600;
		int Minutos = tiempo/ 60 - Horas * 60;
		int Segundos = tiempo- Minutos * 60 - Horas * 3600;
		textTmp.text = Horas.ToString("D2") + " : " + Minutos.ToString("D2") + " : " + Segundos.ToString("D2");
		print (textTmp.text);


	}
}

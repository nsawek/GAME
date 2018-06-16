using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Wyświetla na żywo ilość zdobytych przez gracza punktów. 
/// </summary>
public class SCORETEXT : MonoBehaviour {

    public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Punkty: " + FindObjectOfType<POINTS>().Score;
	}
}

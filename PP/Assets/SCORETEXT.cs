﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORETEXT : MonoBehaviour {

    public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Punkty: " + FindObjectOfType<POINTS>().Score;
	}
}

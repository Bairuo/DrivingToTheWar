﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNewNote : MonoBehaviour {

	public int i ;

	// Use this for initialization
	void Start () {
		EventButton.buttons [i] = true;
		EventButton.ifNoteChange = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	
	// Update is called once per frame
	void Update () {
		if (Input.GameKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused)	
			{
				Resume ();	
			} else
			{
				Pause ();

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathMenu : MonoBehaviour {

	public void MainMenu ()
	{
		SceneManager.LoadScene ("Start Screen");
	}


	public void QuitButton ()
	{
		Application.Quit ();
	}

}

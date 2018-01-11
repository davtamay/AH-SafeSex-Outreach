﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {


	public void Load(string name){

		SceneManager.LoadScene (name);
	}
	public void LoadURL(string url){

		Application.OpenURL (url);
	//	Application.Quit ();
	
	}

}

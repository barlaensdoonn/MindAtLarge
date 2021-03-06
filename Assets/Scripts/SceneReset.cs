﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReset : MonoBehaviour
{
    private fogAnimator fog;
    private Scene curScene;
	// Use this for initialization
	void Start ()
    {
        curScene = SceneManager.GetActiveScene();
        fog = GetComponent<fogAnimator>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        KeyCode keyCode = KeyCode.R;
		if(Input.GetKeyDown(keyCode))
        {
            SceneManager.UnloadSceneAsync(curScene);
            SceneManager.LoadScene(curScene.name, LoadSceneMode.Single);
            fog.ResetMe();
        }
	}
}

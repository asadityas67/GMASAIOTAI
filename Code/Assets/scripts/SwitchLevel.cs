﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchLevel : MonoBehaviour {


    public int lvl;

	public void LoadLevel()
    {
        SceneManager.LoadScene(lvl);
    }
}
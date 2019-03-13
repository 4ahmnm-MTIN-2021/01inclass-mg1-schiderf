﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour 
{
    public void SwitchToScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
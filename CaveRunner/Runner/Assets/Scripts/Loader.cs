﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public string sceneName;

    private void OnEnable()
    {
        SceneManager.LoadScene(sceneName);
    }
}

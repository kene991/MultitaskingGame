﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{

    public void PlayAgain()
    {
        SceneManager.LoadScene("MainGame");
    }
}

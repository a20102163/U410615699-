﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public void OnStartGame(string ScneneName)
    {
        Application.LoadLevel(ScneneName);
    }

    public void exitgame()
    {
        Application.Quit();
    }
}
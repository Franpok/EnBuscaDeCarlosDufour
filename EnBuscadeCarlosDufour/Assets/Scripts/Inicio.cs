﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Inicio : MonoBehaviour
{
    void Start()
    {
        
    }
    public void jugar()
    {
        Debug.Log("E");
        SceneManager.LoadScene(1);
    }
}

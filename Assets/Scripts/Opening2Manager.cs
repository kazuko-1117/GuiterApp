﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening2Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene",4.5f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ChangeScene()
    {
         SceneManager.LoadScene("Select");
    }
}

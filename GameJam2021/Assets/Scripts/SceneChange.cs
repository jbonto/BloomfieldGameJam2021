﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public string levelName;
    // Start is called before the first frame update
    public void OnClick(){
        SceneManager.LoadScene(levelName);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Objective : MonoBehaviour
{
    public string levelName;
    void OnMouseDown()
    {
        SceneManager.LoadScene(levelName);
    }
}

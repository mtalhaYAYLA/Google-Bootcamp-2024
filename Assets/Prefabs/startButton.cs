using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{

    public void Closeb() 
    {
        Application.Quit();
    }
    
    public void Startb()
    {
        SceneManager.LoadScene("Oyun");
    }
}

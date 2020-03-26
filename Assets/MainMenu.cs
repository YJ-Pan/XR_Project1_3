using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject MenuCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.UnloadScene(0);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        //MenuCanvas.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

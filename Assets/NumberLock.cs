using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberLock : MonoBehaviour
{
    public string password;
    string enterPW;
    public Text PWdisplay;
    public GameObject Lock;
    public GameObject Check;
    // Start is called before the first frame update
    void Start()
    {
        enterPW = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NumberClick(string num)
    {
        enterPW += num;
        PWdisplay.text = enterPW;
    }

    public void EnterClick()
    {
        if (enterPW == password)
        {
            PWdisplay.text = "Correct!";
            Check.SetActive(true);
        }
        else
        {
            PWdisplay.text = "Wrong!";
        }
        enterPW = "";
    }

    public void DelClick()
    {
        PWdisplay.text = "";
        enterPW = "";
    }

    public void CloseClick()
    {
        //Lock.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.UnloadScene(2);
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}

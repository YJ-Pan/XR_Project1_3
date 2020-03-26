using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject maincharacter;
    public GameObject Password;
    public float playDis;
    bool isShow;
    float dis;
    // Start is called before the first frame update
    void Start()
    {
        isShow = false;
        dis = 0;
    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector3.Distance(maincharacter.transform.position, this.transform.position);
        if (dis < 0) dis *= -1;
        if (dis < playDis && !isShow)
        {
            UnityEngine.SceneManagement.SceneManager.UnloadScene(1);
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);

            //Password.SetActive(true);
            //isShow = true;
        }
        else if (dis > playDis + 2)
        {
            //isShow = false;
            //Password.SetActive(false);

        }
    }
}

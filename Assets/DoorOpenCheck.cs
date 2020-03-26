using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenCheck : MonoBehaviour
{
    public GameObject Check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenClick()
    {
        Check.SetActive(false);
        //OpenDoor()
    }

    public void CloseClick()
    {
        Check.SetActive(false);
    }
}

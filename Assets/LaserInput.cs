using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class LaserInput : MonoBehaviour
{
    public static GameObject currentObject;
    public GameObject controller;
    public bool trigger = false;
    int currentID;
    // Start is called before the first frame update
    void Start()
    {
        currentObject = null;
        currentID = 0;
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 100.0f);

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            int id = hit.collider.gameObject.GetInstanceID();

            if (currentID != id)
            {
                currentID = id;
                currentObject = hit.collider.gameObject;

                string name = currentObject.name;
                string tag = currentObject.tag;
                if (tag == "Button")
                {
                    Debug.Log("Select Button");
                    currentObject.GetComponent<Button>().Select();
                    trigger = this.GetComponent<SteamVR_LaserPointer>().trigger;
                    if (controller.GetComponent<SteamVR_LaserPointer>().trigger)
                    {
                        currentObject.GetComponent<Button>().onClick.Invoke();
                    }
                    //currentObject.GetComponent<Button>().OnDeselect(null);
                }

            }
        }
    }
}

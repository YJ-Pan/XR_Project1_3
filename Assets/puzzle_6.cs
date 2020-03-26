using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class puzzle_6 : MonoBehaviour
{
    // Start is called before the first frame update
    public static int judge6;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "6")
        {
            print("6");
            judge6 = 1;
            print(judge6);
        }
    }
}
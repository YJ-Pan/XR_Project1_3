using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class puzzle_7 : MonoBehaviour
{
    // Start is called before the first frame update
    public static int judge7;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "7")
        {
            print("7");
            judge7 = 1;
            print(judge7);
        }
    }
}

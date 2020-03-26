using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class judge : MonoBehaviour
{
    public GameObject A;
    public int count = 0;

    void Update()
    {
        judgement();
    }

    public void judgement()
    {
        if (puzzle_6.judge6 == 1 && puzzle_7.judge7 == 1 && count == 0)
        {
            print("hello!");
            A.gameObject.SetActive(true);
            count++;
        }
    }
}
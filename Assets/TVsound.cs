using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVsound : MonoBehaviour
{
    public GameObject maincharacter;
    public AudioSource audio;
    public float playDis;

    float dis;
    bool isAudioPlay;
    // Start is called before the first frame update
    void Start()
    {
        dis = 0;
        isAudioPlay = false;
    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector3.Distance(maincharacter.transform.position, this.transform.position);
        if (dis < 0) dis *= -1;
        if (dis < playDis && maincharacter.transform.position.z > 2.4 && !isAudioPlay)
        {
            audio.Play();
            isAudioPlay = true;
            Debug.Log("Play");
        }
        else if(dis > playDis + 3)
        {
            isAudioPlay = false;
            Debug.Log("UnPlay");
        }

    }
}

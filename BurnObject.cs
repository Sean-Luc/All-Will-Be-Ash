using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnObject : MonoBehaviour
{
    //public AudioSource collectSound;
    float time;
    public float timeDelay;
    public GameObject fire;
    public NewPlayerController player;
    public float sizeincrease;
    public float objectsize;
    Collider collide;
    Collider collide2;

    void Start () 
    {
        time = 0f;
        timeDelay = 100000f;
        collide = GetComponent<Collider>();
        collide2 = GetComponent<Collider>();
    }

    void Update()
    {
        time = time + 1f * Time.deltaTime;

        if(time >= timeDelay)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(player.size >= objectsize)
        {
            time = 0;
            timeDelay = 7;
            fire.SetActive(true);
            player.makebigger(sizeincrease);
            collide.enabled = false;
            collide2.enabled = false;
        }
    }
}

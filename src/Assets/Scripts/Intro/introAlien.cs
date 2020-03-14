﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introAlien : MonoBehaviour
{
    public GameObject NPCAlive;
    public GameObject NPCDead;
    public GameObject AlienExplosions;
    public GameObject Aliens;
    public GameObject Avatar;
    // Start is called before the first frame update
    void Start()
    {
        NPCAlive.SetActive(false);
        NPCDead.SetActive(true);
        AlienExplosions.SetActive(true);
        Aliens.SetActive(true);
        Avatar.GetComponent<Animator>().Play("Panic");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

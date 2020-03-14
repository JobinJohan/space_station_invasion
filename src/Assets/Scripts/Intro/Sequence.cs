﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence : MonoBehaviour
{
    int SequenceNb = 0;
    public GameObject[] sequencesRef;
    // Start is called before the first frame update
    void Start()
    {
        sequencesRef[SequenceNb].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextSequence()
    {
        this.SequenceNb++;
        switch (this.SequenceNb)
        {
            case 1:
                sequencesRef[SequenceNb].SetActive(true);
                break;
            case 2:
                sequencesRef[SequenceNb].SetActive(true);
                break;
            case 3:
                sequencesRef[SequenceNb].SetActive(true);
                break;
            case 4:
                sequencesRef[SequenceNb].SetActive(true);
                sequencesRef[SequenceNb - 2].SetActive(false);
                break;
            case 5:
                sequencesRef[SequenceNb].SetActive(true);
                break;
            case 6:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                //GameObject.Find("GameManager").GetComponent<gamemanager>().LoadScene("Scenes/1_level");
                break;
            default:
                return;
        }
    }
}

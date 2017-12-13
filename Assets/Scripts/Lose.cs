using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour {

    public GameObject play;

    private void Start()
    {
        play = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame

    void OnBecameInvisible()
    {
        Debug.Log("Hi");
    }
    void OnBecameVisible()
    {
        Debug.Log("Hi");
    }
}

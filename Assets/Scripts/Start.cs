using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {

    public GameObject play;
    public GameObject mulai;
    public GameObject buttonScore;
    public Transform canvas;

    public void onClick()
    {
        play.SetActive(true);
        Destroy(buttonScore);
        Destroy(mulai);
    }

}

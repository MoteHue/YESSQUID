using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiverTrigger : MonoBehaviour
{
    //public Text endScore;
    //public ScoreCounter scoreCounter;
    public bool ended;
    //private int score;

    // Start is called before the first frame update
    void Start()
    {
        //score = scoreCounter.score;
        ended = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        ended = true;
    }
}

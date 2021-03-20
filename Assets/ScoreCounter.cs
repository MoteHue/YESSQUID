using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public int generations;

    // Start is called before the first frame update
    void Start()
    {
        score = -10;
        generations = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

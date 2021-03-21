using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Stats;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public int generations;
    public GameObject overflow;

    // Start is called before the first frame update
    void Start()
    {
        score = Stats._score-10;
        generations = Stats._generations;
    }

    // Update is called once per frame
    void Update()
    {
        if (generations >= 6) overflow.SetActive(true);
    }
}

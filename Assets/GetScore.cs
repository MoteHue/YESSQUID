using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    public Text scoreUI;
    private int score;
    private int generations;

    // Start is called before the first frame update
    void Start()
    {
        score = scoreCounter.score;
        generations = scoreCounter.generations;
    }

    // Update is called once per frame
    void Update()
    {
        score = scoreCounter.score;
        generations = scoreCounter.generations;
        scoreUI.text = "Score: " + score + "\nGeneration: " + generations;
    }
}

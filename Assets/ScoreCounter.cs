using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Database;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public int generations;

    // Start is called before the first frame update
    void Start()
    {
        DatabaseConnector.GetYear((int year, bool isEnd) => {
            Debug.Log(year);
            Debug.Log(isEnd);
        });

        score = -10;
        generations = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

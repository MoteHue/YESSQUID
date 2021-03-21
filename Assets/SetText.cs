using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using static Stats;

public class SetText : MonoBehaviour
{
    public GameObject variables;
    int s,g;
    public Text t;
    public int start,end;
    public int s_start,s_end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetYear(){
        int diff = end-start;
        return start + g*(diff / (10));
    }

    int GetSalmonNumber(){
        int diff = s_start-s_end;
        return s_start - g*(diff/10);
    }

    void Awake(){
        s = Stats._score;
        g = Stats._generations;
        g = g+1;
        TransitionMessage();

        Stats._generations = g+1;
    }

    void TransitionMessage(){
        //
        int year = GetYear();
        int num = GetSalmonNumber();
        t.text = String.Format("You are now in generation {0}\nYour total lifetime score is {3}\nThe year is {1}\n\nThere are roughly {2} salmon left in Snake River, Northern USA\n\nTry to continue your lineage for another generation in these\nharsher conditions left by climate change", g, year, num, s);
    }
}

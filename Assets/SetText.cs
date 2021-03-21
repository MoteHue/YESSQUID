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
        return Math.Min(s_start - g*(diff/10),1);
    }

    void Awake(){
        s = Stats._score;
        g = Stats._generations;
        g = g+1;
        TransitionMessage();

        Stats._generations = g;
    }

    void TransitionMessage(){
        //
        int year = GetYear();
        int num = GetSalmonNumber();
        if (num <= 1) t.text = String.Format("You are now in generation {0}\nYour total lifetime score is {2}\nThe year is {1}\n\nYou are one of the only remaining salmon left in Snake River, Northern USA\nOther fish are rarer and there are more obstacles in the river\n\nHow much longer can your lineage survive in these \nharsher conditions left by climate change", g, year, s);
        else t.text = String.Format("You are now in generation {0}\nYour total lifetime score is {3}\nThe year is {1}\n\nThere are roughly {2} salmon left in Snake River, Northern USA\nOther fish are rarer and there are more obstacles in the river\n\nTry to continue your lineage for another generation in these\nharsher conditions left by climate change", g, year, num, s);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Stats
{
    private static int score = 0;
    private static int generations = 1;
    private static int t;
    private static string username = "aaa";

    public static int _score{
        get{
            return score;
        }
        set{
            score = value;
        }
    }

    public static int _generations{
        get{
            return generations;
        }
        set{
            generations = value;
        }
    }

    public static int _t{
        get{
            return t;
        }
        set{
            t = value;
        }
    }

    public static string _username {
        get {
            return username;
        }
        set {
            username = value;
        }
    }
}


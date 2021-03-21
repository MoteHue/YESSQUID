using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public ScoreCounter score; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad (transform.gameObject);
    }

    void Awake(){
        DontDestroyOnLoad (transform.gameObject);
    }
}

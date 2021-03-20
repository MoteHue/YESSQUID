using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckEnemies : MonoBehaviour
{
    public PlayerController movement;
    public GameObject ui;
    public Text _reason;
    
    // Start is called before the first frame update
    void Start()
    {
        movement = GameObject.FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameOver(string reason){
        DisableMovement();
        Debug.Log(reason);
        ui.SetActive(true);
        _reason.text = reason;
    }

    void DisableMovement(){
        movement.enabled = false;
    }

    void OnCollisionEnter (Collision col){
        //TODO
        if (col.transform.name == "Line"){
            GameOver("You were caught by a fisherman");
        }
    }  
}

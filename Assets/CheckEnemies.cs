using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckEnemies : MonoBehaviour
{
    public PlayerController movement;
    public GameObject ui;
    public Text _reason;
    public Text _score;
    public ScoreCounter scoreCounter;

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
        Debug.Log("Game Over - " + reason);
        ui.SetActive(true);
        _reason.text = reason;
        int s = scoreCounter.score;
        _score.text = "Your final score was " + s;
    }

    void IncrementScore(int amount){
        scoreCounter.score += amount;
    }

    void DisableMovement(){
        movement.enabled = false;
    }

    void OnTriggerEnter (Collider t){
        switch (t.transform.name){
            case "Insect":
                IncrementScore(5);
                Debug.Log("yom yom tasty INSECT");
                break;
            default:
                break;
        }
    }

    void OnCollisionEnter (Collision col){
        //TODO
        switch (col.transform.name){
            case "Line":
                GameOver("You were caught by a fisherman");
                break;
            case "Rock":
                GameOver("You sustained injuries from colliding with a rock");
                break;
            case "Bird":
                GameOver("You were scooped up by a bird and eaten");
                break;
            case "Bear":
                GameOver("You were eaten by a bear");
                break;
            case "Debris":
                GameOver("You got suffocated by debris");
                break;
            //case "Insect":
            //    IncrementScore(5);
            //    Debug.Log("yom yom tasty INSECT");
            //    break;
            default:
                break;
        }
    }  
}

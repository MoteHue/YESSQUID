using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Stats;

public class CheckEnemies : MonoBehaviour
{
    public PlayerController movement;
    public GameObject ui;
    public GameObject complete_ui;
    public Text _reason;
    public Text _score;
    public Text _finalScore;
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

    void LevelComplete(){
        scoreCounter.score += 30;
        DisableMovement();
        complete_ui.SetActive(true);
        int s = scoreCounter.score;
        int g = scoreCounter.generations;
        _finalScore.text = "Your score was " + s +"\nYou have completed generation " + g;

        Stats._score = s;
        Stats._generations = g;
    }

    void GameOver(string reason){
        DisableMovement();
        Debug.Log("Game Over - " + reason);
        ui.SetActive(true);
        _reason.text = reason;
        int s = scoreCounter.score;
        int g = scoreCounter.generations;
        _score.text = "Your final score was " + s + "\nYour line survived for " + g + " generation";
        if (g != 1) _score.text += "s";
    }

    void IncrementScore(int amount){
        scoreCounter.score += amount;
    }

    void DisableMovement(){
        movement.enabled = false;
    }

    void OnTriggerEnter (Collider t){
        switch (t.gameObject.tag){
            case "Bug":
                t.gameObject.SetActive(false);
                IncrementScore(5);
                //Debug.Log("yom yom tasty INSECT");
                break;
            case "FishFood":
                t.gameObject.SetActive(false);
                IncrementScore(1);
                break;
            case "RiverEnd":
                LevelComplete();
                break;
            default:
                break;
        }
    }

    void OnCollisionEnter (Collision col){
        //TODO
        switch (col.gameObject.tag){
            case "Rod":
                GameOver("It's the end of the LINE for this fish");
                break;
            case "Log":
                GameOver("Your death has been LOGged with an administrator");
                break;
            case "Rock":
                GameOver("That was a bold move. Missing the rock would've been BOULDER");
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
            default:
                break;
        }
    }  
}

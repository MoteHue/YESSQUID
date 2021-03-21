using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Database;
using UnityEngine.UI;

public class GameOverBehaviour : MonoBehaviour
{
    public InputField ifield;

    public void Restart() {
        

        Stats._generations = 1;
        Stats._score = 0;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void SubmitScore() {
        Stats._username = ifield.text;
        DatabaseConnector.NewScore(Stats._username, Stats._score);
    }

    public void Continue() {
        SceneManager.LoadScene("Transition");
    }
}

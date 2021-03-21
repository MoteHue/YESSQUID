using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Database;
using UnityEngine.UI;

public class GameOverBehaviour : MonoBehaviour
{
    public InputField ifield;
    public Button button;

    public void Restart() {
        button.gameObject.SetActive(true);

        Stats._generations = 1;
        Stats._score = 0;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void SubmitScore() {
        Stats._username = ifield.text;
        DatabaseConnector.NewScore(Stats._username, Stats._score);
        button.gameObject.SetActive(false);
    }

    public void Continue() {
        SceneManager.LoadScene("Transition");
    }
}

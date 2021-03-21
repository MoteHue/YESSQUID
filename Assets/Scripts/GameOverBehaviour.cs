using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Database;

public class GameOverBehaviour : MonoBehaviour
{
    public void Restart() {
        DatabaseConnector.NewScore(Stats._username, Stats._score);

        Stats._generations = 1;
        Stats._score = 0;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void Continue() {
        SceneManager.LoadScene("Transition");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomisable : MonoBehaviour
{
    PlayerController player;

    // Start is called before the first frame update
    void Start() {
        player = FindObjectOfType<PlayerController>();
        int number = Mathf.RoundToInt(player.transform.position.z);
        Debug.Log(player.transform.position.z);
        if (number % 7 < 2) {
            Destroy(gameObject);
        }
    }

}

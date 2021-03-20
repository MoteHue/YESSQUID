using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TriggerBehaviour : MonoBehaviour
{
    public GameObject OtherRiverSegment;
    ScoreCounter score;
    PlayerController player;
    public GameObject RiverEnd;

    public int _distanceBasedScore = 10;

    private void Start() {
        player = FindObjectOfType<PlayerController>();
        score = FindObjectOfType<ScoreCounter>();
        List<Randomisable> randomisables = OtherRiverSegment.GetComponentsInChildren<Randomisable>(true).ToList();
        foreach (Randomisable r in randomisables) {
            r.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other) {
        player.counter++;
        if (player.counter < 10) {
            OtherRiverSegment.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 218f);
        } else {
            
        }
        

        score.score+= _distanceBasedScore;
        

        List<Randomisable> randomisables = OtherRiverSegment.GetComponentsInChildren<Randomisable>(true).ToList();
        foreach (Randomisable r in randomisables) {
            r.gameObject.SetActive(Random.Range(0, 10) <= 4);
        }
    }

}

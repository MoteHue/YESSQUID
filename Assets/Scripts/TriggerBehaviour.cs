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
        if (player.counter < player.gameEndsAfterSegments) {
            OtherRiverSegment.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 218f);
        } else {
            Instantiate(RiverEnd, new Vector3(transform.position.x + 2.7f, transform.position.y, transform.position.z + 170f), transform.rotation);
        }
        

        score.score+= _distanceBasedScore;
        

        List<Randomisable> randomisables = OtherRiverSegment.GetComponentsInChildren<Randomisable>(true).ToList();
        foreach (Randomisable r in randomisables) {
            int rand = Random.Range(r.min, r.max);
            if (Stats._generations >= r.minGenReq) r.gameObject.SetActive(rand <= r.thresh + Stats._generations);
        }
    }

}

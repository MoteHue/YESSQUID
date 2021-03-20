using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TriggerBehaviour : MonoBehaviour
{
    public GameObject OtherRiverSegment;
    ScoreCounter score;

    public int _distanceBasedScore = 10;

    private void Start() {
        score = FindObjectOfType<ScoreCounter>();
    }

    private void OnTriggerEnter(Collider other) {
        OtherRiverSegment.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 218f);

        score.score+= _distanceBasedScore;

        List<Randomisable> randomisables = OtherRiverSegment.GetComponentsInChildren<Randomisable>(true).ToList();
        foreach (Randomisable r in randomisables) {
            r.gameObject.SetActive(Random.Range(0, 10) <= 4);
        }
    }

}

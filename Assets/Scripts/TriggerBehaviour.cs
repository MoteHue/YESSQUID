using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    public GameObject RiverSegment;
    public GameObject parent;

    public bool isFirstTrigger;

    private void OnTriggerEnter(Collider other) {
        if (isFirstTrigger) {
            Instantiate(RiverSegment, gameObject.GetComponentInParent<Transform>().position + new Vector3(0f, 0f, 218f), gameObject.GetComponentInParent<Transform>().rotation);
        } else {
            Destroy(parent);
        }
    }

}

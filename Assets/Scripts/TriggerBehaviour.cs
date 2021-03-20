using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    public GameObject RiverSegment;
    public GameObject parent;

    private void OnTriggerEnter(Collider other) {
        Instantiate(RiverSegment, gameObject.GetComponentInParent<Transform>().position + new Vector3(0f, 0f, 173.5f), gameObject.GetComponentInParent<Transform>().rotation);
        Invoke(nameof(Die), 15f);
    }

    void Die() {
        Destroy(parent);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float riverSpeed;

    Vector3 moveForce;
    Vector3 riverForce;
    Animator animator;

    Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        moveForce = new Vector3();
        riverForce = new Vector3(0f, 0f, riverSpeed);
    }

    private void FixedUpdate() {
        moveForce = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * moveSpeed;

        rb.AddForce(moveForce + riverForce);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            animator.SetTrigger("Jump");
        }
    }
}

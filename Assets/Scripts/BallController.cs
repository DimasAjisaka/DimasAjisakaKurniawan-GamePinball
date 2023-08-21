using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    private Rigidbody rig;
    [SerializeField] private float maxSpeed;

    private void Start() {
        rig = GetComponent<Rigidbody>();
    }

    private void Update() {
        if (rig.velocity.magnitude > maxSpeed) {
            rig.velocity = rig.velocity.normalized * maxSpeed;
        }
    }
}

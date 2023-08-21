using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerZoomInController : MonoBehaviour {
    [SerializeField] private Collider ball;
    [SerializeField] private CameraController controller;
    [SerializeField] private float length;

    private void OnTriggerEnter(Collider other) {
        if (other == ball) {
            controller.FollowTarget(ball.transform, length);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerZoomOutController : MonoBehaviour {
    [SerializeField] private Collider ball;
    [SerializeField] private CameraController controller;

    private void OnTriggerEnter(Collider other) {
        if (other == ball) {
            controller.GoBackToDefault();
        }
    }
}

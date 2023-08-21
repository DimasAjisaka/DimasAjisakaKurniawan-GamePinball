using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerRampController : MonoBehaviour {
    [SerializeField] private float score;
    [SerializeField] private Collider ball;
    [SerializeField] private ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other) {
        if (other == ball) {
            scoreManager.AddScore(score);
        }
    }
}

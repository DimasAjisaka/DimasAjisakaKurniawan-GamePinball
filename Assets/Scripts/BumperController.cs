using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour {

    [SerializeField] private Collider ball;
    [SerializeField] private float multiplier;
    [SerializeField] private Color color;
    [SerializeField] private float score;

    [SerializeField] private AudioManager audioManager;
    [SerializeField] private VFXManager vfxManager;
    [SerializeField] private ScoreManager scoreManager;

    private Renderer rendered;
    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
        rendered = GetComponent<Renderer>();
        rendered.material.color = color;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider == ball) {
            Rigidbody ballRig = ball.GetComponent<Rigidbody>();
            ballRig.velocity *= multiplier;

            //animation
            animator.SetTrigger("hit");

            //play sfx
            audioManager.PlaySFX(collision.transform.position);

            //playvfx
            vfxManager.PlayVFX(collision.transform.position);

            //Add Score
            scoreManager.AddScore(score);
        }
    }
}

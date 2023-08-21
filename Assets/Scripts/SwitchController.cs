using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {
    private enum SwitchState {
        On,
        Off,
        Blink,
    }

    [SerializeField] private Collider ball;
    [SerializeField] private Material onMaterial;
    [SerializeField] private Material offMaterial;
    [SerializeField] private float score;

    [SerializeField] private ScoreManager scoreManager;

    private SwitchState state;
    private Renderer rendered;

    private void Start() {
        rendered = GetComponent<Renderer>();
        SetSwitch(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other) {
        if (other == ball) {
            Toggle();
        }
    }

    private void SetSwitch(bool active) {
        if (active == true) {
            state = SwitchState.On;
            rendered.material = onMaterial;
            StopAllCoroutines();
        } else {
            state = SwitchState.Off;
            rendered.material = offMaterial;
        }
    }

    private void Toggle() {
        if (state == SwitchState.On) {
            SetSwitch(false);
        } else {
            SetSwitch(true);
            scoreManager.AddScore(score);
        }
    }

    private IEnumerator Blink(int times) {
        state = SwitchState.Blink;
        
        for(int i = 0; i < times; i++) {
            rendered.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            rendered.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }
        
        state = SwitchState.Off;
        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time) {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}

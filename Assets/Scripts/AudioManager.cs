using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    [SerializeField] private AudioSource bgmAudio;
    [SerializeField] private GameObject sfxAudio;
    
    private void Start() {
        PlayBGM();
    }

    private void PlayBGM() {
        bgmAudio.Play();
    }

    public void PlaySFX(Vector3 spawnPosition) {
        GameObject.Instantiate(sfxAudio, spawnPosition, Quaternion.identity);
    }
}

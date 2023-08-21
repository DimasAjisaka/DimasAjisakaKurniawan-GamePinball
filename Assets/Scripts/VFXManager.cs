using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour {
    [SerializeField] private GameObject vfxSource;

    public void PlayVFX(Vector3 spawnPosition) {
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour {
    [SerializeField] private Button backToMenuButton;

    private void Start() {
        backToMenuButton.onClick.AddListener(MainMenu);
    }

    private void MainMenu() {
        SceneManager.LoadScene("MainMenuScene");
    }
}

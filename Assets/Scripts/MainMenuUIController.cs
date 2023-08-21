using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour {
    [SerializeField] private Button playButton;
    [SerializeField] private Button creditButton;
    [SerializeField] private Button exitButton;

    [SerializeField] private GameObject creditMenu;
    [SerializeField] private GameObject mainMenu;

    private void Start() {
        playButton.onClick.AddListener(PlayGame);
        creditButton.onClick.AddListener(CreditMenu);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void PlayGame() {
        SceneManager.LoadScene("MainScene");
    }

    private void CreditMenu() {
        creditMenu.SetActive(true); 
        mainMenu.SetActive(false);
    }

    private void ExitGame() {
        Application.Quit();
    }
}

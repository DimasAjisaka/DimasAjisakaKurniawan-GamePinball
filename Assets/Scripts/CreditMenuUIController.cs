using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditMenuUIController : MonoBehaviour {
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject creditMenu;
    [SerializeField] private GameObject mainMenu;

    private void Start() {
        backButton.onClick.AddListener(BackMenu);
    }

    private void BackMenu() {
        creditMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}

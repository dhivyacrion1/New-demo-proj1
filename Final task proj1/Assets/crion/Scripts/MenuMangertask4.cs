using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagertask4 : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject homeScreen;
    public GameObject settingsScreen;
    public GameObject aboutScreen;

    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        homeScreen.SetActive(false);
        settingsScreen.SetActive(false);
        aboutScreen.SetActive(false);
    }

    public void StartApp()
    {
        mainMenu.SetActive(false);
        homeScreen.SetActive(true);
    }

    public void OpenSettings()
    {
        mainMenu.SetActive(false);
        settingsScreen.SetActive(true);
    }

    public void OpenAbout()
    {
        mainMenu.SetActive(false);
        aboutScreen.SetActive(true);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMainMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject mainMenu;

    public void Start()
    {
        showmainMenu();
    }
    public void LoadCatchMe()
    {
        SceneManager.LoadScene("BallSpawner");
    }
    public void showmainMenu()
    {
        mainMenu.SetActive(true);
        settingsPanel.SetActive(false);
    }


    public void LoadQuickColourTap()
    {
        SceneManager.LoadScene("ChangingCubeColours");
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        showmainMenu();
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }
}

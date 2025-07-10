using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    public Button optionsButton;
    public Sprite optionsNormal;
    public Sprite optionsClicked;

    public Button exitButton;
    public Animator exitAnimator;

    void Start()
    {
        // Reset Options button to normal sprite on start
        if (optionsButton != null && optionsNormal != null)
        {
            optionsButton.image.sprite = optionsNormal;
        }

        // Reset Exit animation state
        if (exitAnimator != null)
        {
            exitAnimator.SetBool("isHover", false);
        }
    }

    // Start Game
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Back to Start
    public void BackToStart()
    {
        SceneManager.LoadScene(0);
    }

    // Quit Game
    public void QuitGame()
    {
        Application.Quit();
    }

    // Options button click: swap sprite then reset
    public void OpenOptions()
    {
        if (optionsButton != null && optionsClicked != null && optionsNormal != null)
        {
            optionsButton.image.sprite = optionsClicked;
            Invoke("ResetOptionButtonSprite", 0.2f); // reset after 0.2 sec
        }
    }

    void ResetOptionButtonSprite()
    {
        optionsButton.image.sprite = optionsNormal;
    }

    // Exit button hover enter
    public void ExitButtonEnter()
    {
        if (exitAnimator != null)
        {
            exitAnimator.SetBool("isHover", true);
        }
    }

    // Exit button hover exit
    public void ExitButtonExit()
    {
        if (exitAnimator != null)
        {
            exitAnimator.SetBool("isHover", false);
        }
    }
}

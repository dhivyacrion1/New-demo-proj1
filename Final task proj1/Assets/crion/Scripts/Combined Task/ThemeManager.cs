using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThemeManager : MonoBehaviour
{
    public TMP_Dropdown themeDropdown;

    public Image backgroundPanel;
    public Image backgroundPanel1;
    public Button[] buttons;
    public TMP_Text[] texts;

    void Start()
    {
        themeDropdown.onValueChanged.AddListener(delegate {
            ThemeDropdownValueChanged(themeDropdown);
        });

        ApplyBluePinkTheme(); 
        themeDropdown.value = 2; // Update dropdown selection to BluePink (index 2)
    }

    void ThemeDropdownValueChanged(TMP_Dropdown change)
    {
        switch (change.value)
        {
            case 0:
                ApplyDarkTheme();
                break;
            case 1:
                ApplyBlueTheme();
                break;
            case 2:
                ApplyBluePinkTheme();
                break;
        }
    }

    void ApplyDarkTheme()
    {
        backgroundPanel.color = Color.black;

        foreach (Button btn in buttons)
        {
            ColorBlock cb = btn.colors;
            cb.normalColor = Color.grey;
            cb.highlightedColor = Color.white;
            btn.colors = cb;
        }

        foreach (TMP_Text txt in texts)
        {
            txt.color = Color.white;
        }

        Debug.Log("Dark theme applied");
    }

    void ApplyBlueTheme()
    {
        backgroundPanel.color = Color.blue;

        foreach (Button btn in buttons)
        {
            ColorBlock cb = btn.colors;
            cb.normalColor = new Color(0.1f, 0.2f, 1f); // Light blue
            cb.highlightedColor = Color.white;
            btn.colors = cb;
        }

        foreach (TMP_Text txt in texts)
        {
            txt.color = Color.white;
        }

        Debug.Log("Blue theme applied");
    }

    void ApplyBluePinkTheme()
    {
        backgroundPanel.color = new Color(1f, 0.4f, 0.7f); // Pink

        foreach (Button btn in buttons)
        {
            ColorBlock cb = btn.colors;
            cb.normalColor = new Color(0.4f, 0.7f, 1f); // Light blue for buttons
            cb.highlightedColor = new Color(1f, 0.6f, 0.8f); // Light pink highlight
            btn.colors = cb;
        }

        foreach (TMP_Text txt in texts)
        {
            txt.color = Color.white;
        }

        Debug.Log("BluePink theme applied");
    }
}

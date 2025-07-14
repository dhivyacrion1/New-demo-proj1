using UnityEngine;
using TMPro;

public class InputColourChanger : MonoBehaviour
{
    public MeshRenderer cube;
    public TMP_InputField inputField;
    public TextMeshProUGUI colourText; // Reference to your Text (TMP) UI

    public void ChangeColour()
    {
        string colorName = inputField.text.ToLower();

        Color newColor;

        switch (colorName)
        {
            case "red":
                newColor = Color.red;
                break;
            case "green":
                newColor = Color.green;
                break;
            case "blue":
                newColor = Color.blue;
                break;
            case "yellow":
                newColor = Color.yellow;
                break;
            case "black":
                newColor = Color.black;
                break;
            case "white":
                newColor = Color.white;
                break;
            case "pink":
                newColor = new Color(1f, 0.4f, 0.7f);
                break;
            case "orange":
                newColor = new Color(1f, 0.5f, 0f);
                break;
            default:
                Debug.Log("Invalid colour name typed.");
                return;
        }

        // Change cube colour
        cube.material.color = newColor;

        // Update Text
        colourText.text = "I am " + colorName;
        colourText.color = newColor; // Change text colour to match
    }
}


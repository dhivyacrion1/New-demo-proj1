using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubeController : MonoBehaviour
{
    public GameObject cube;                  // Reference to the cube
    public Slider sizeSlider;               // Slider for size adjustment
    public TMP_InputField nameInput;            // Input for new name
    public TMP_Text cubeNameText;               // UI text to show name
    public Button changeNameButton;         // Button to change name

    private void Start()
    {
        // Set default size
        sizeSlider.value = cube.transform.localScale.x;

        // Add listener to the slider
        sizeSlider.onValueChanged.AddListener(UpdateCubeSize);

        // Add listener to the button
        changeNameButton.onClick.AddListener(ChangeCubeName);
    }

    void UpdateCubeSize(float newSize)
    {
        // Update cube scale uniformly
        cube.transform.localScale = new Vector3(newSize +3, newSize+3, newSize+3);
    }

    void ChangeCubeName()
    {
        string newName = nameInput.text;

        if (!string.IsNullOrEmpty(newName))
        {
            cube.name = newName;
            cubeNameText.text = "Cube Name: " + newName;
        }
    }
}
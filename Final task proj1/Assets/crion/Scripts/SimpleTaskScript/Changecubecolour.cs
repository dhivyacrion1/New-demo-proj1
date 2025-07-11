using UnityEngine;
using TMPro;

public class CubeColorUIChanger : MonoBehaviour
{
    private Renderer cubeRenderer;

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    public void ChangeToRed()
    {
        cubeRenderer.material.color = Color.red;
    }

    public void ChangeToGreen()
    {
        cubeRenderer.material.color = Color.green;
    }

    public void ChangeToyellow()
    {
        cubeRenderer.material.color = Color.yellow;
    }

    // You can add more colors similarly
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ball : MonoBehaviour
{
    public string ballColour;
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Catcher"))
        {
            if (ballColour == "Blue")
            {
                gameManager.AddScore();
            }
            else if (ballColour == "Pink")
            {
                gameManager.ReduceLife();
            }

            Destroy(gameObject);
        }
    }
}

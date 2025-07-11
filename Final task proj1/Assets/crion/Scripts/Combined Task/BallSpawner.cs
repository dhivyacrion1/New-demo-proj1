using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    public float spawnRangeX = 5f;
    public int totalBalls = 8;

    public Material blueMaterial;
    public Material pinkMaterial;

    private Coroutine spawnRoutine;

    public GameManager gameManager;

    void Start()
    {
        StartSpawning(); // ✅ Automatically start spawning
    }

    public void StartSpawning()
    {
        if (spawnRoutine == null)
        {
            spawnRoutine = StartCoroutine(SpawnBalls());
        }
    }

    IEnumerator SpawnBalls()
    {
        for (int i = 0; i < totalBalls; i++)
        {
            Vector3 randomSpawnPosition = spawnPoint.position;
            randomSpawnPosition.x += Random.Range(-spawnRangeX, spawnRangeX);

            GameObject ball = Instantiate(ballPrefab, randomSpawnPosition, Quaternion.identity);

            Renderer ballRenderer = ball.GetComponentInChildren<Renderer>();
            Ball ballScript = ball.GetComponent<Ball>();

            if (ballRenderer != null && ballScript != null)
            {
                int randomColour = Random.Range(0, 2);

                if (randomColour == 0)
                {
                    ballRenderer.material = blueMaterial;
                    ballScript.ballColour = "Blue";
                }
                else
                {
                    ballRenderer.material = pinkMaterial;
                    ballScript.ballColour = "Pink";
                }

                ballScript.gameManager = gameManager;
            }
            else
            {
                Debug.LogError("Renderer or Ball script not found on ball prefab!");
            }

            yield return new WaitForSeconds(1f);
        }

        spawnRoutine = null;
    }

    public void StopSpawning()
    {
        if (spawnRoutine != null)
        {
            StopCoroutine(spawnRoutine);
            spawnRoutine = null;
        }
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("NewMainMenu");
    }
}

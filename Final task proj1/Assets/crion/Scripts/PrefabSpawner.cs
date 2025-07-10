using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PrefabSpawner : MonoBehaviour
{
    public Dropdown prefabDropdown;
    public Button spawnButton;
    public List<GameObject> prefabList;

    void Start()
    {
        spawnButton.onClick.AddListener(SpawnSelectedPrefab);
    }

    void SpawnSelectedPrefab()
    {
        int index = prefabDropdown.value;
        GameObject prefabToSpawn = prefabList[index];
        Instantiate(prefabToSpawn, Vector3.zero, Quaternion.identity);
    }
}

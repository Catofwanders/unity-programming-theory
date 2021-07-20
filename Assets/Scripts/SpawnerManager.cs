using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    private GameObject spawner;
    public Transform cat;
    public Transform dog;
    public Transform chicken;

    public static SpawnerManager Instance;
    private void Start()
    {
        Instance = this;
        spawner = GameObject.Find("Spawner");
    }

    public void SpawnAnimal(string type)
    {
        switch (type)
        {
            case "cat":
                Instantiate(cat, spawner.transform.parent);
                break;
            case "dog":
                Instantiate(dog, spawner.transform.parent);
                break;
            case "chicken":
                Instantiate(chicken, spawner.transform.parent);
                break;
            default:
                Instantiate(cat, spawner.transform.parent);
                break;
        }
    }
}

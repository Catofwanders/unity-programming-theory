using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text totalText;


    public void CallSpawner(string type){
        SpawnerManager.Instance.SpawnAnimal(type);
        GameManager.Instance.AddAnimal();
        totalText.text = "Total Animals: " + GameManager.Instance.totalAnimal.ToString();
    } 

}

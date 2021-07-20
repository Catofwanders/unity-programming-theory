using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int m_totalAnimal = 0;
    public int totalAnimal {
        get { return m_totalAnimal; }
        private set { m_totalAnimal = value; }
    }
    public static GameManager Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void AddAnimal()
    {
        m_totalAnimal += 1;
    }
}

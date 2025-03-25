using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private Character character;
    public Character CharacterInfo
    {
        get { return character; }
    }

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
                instance = new GameObject("GameManager").AddComponent<GameManager>();

            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
        if(instance != this)
        {
            Destroy(gameObject);
        }

        character = new Character(new List<Item>());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public enum Character
    {
        White,Black
    }
   public static DataManager instance;
    private void Awake()
    {
        if(instance == null)instance = this;
        else if(instance != null)return;
        DontDestroyOnLoad(gameObject);
    }
    public Character currentCharacter;
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEditor.SceneManagement;
public class InputFeld : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public PlayerPrefs playerPrefs;
    private string playerName;

   


    private void Awake()
    {
        
    }

  

    private void Update()
    {
        if (playerNameInput.text.Length > 0 && Input.GetKey(KeyCode.Return))
        {
            LoadMainMap();
        }
        
    }

    private void LoadMainMap()
    {
        playerName = playerNameInput.text;
        PlayerPrefs.SetString("playerName",playerName);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainMap");
       

    }

    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DataManager;


public class SelectCharacter : MonoBehaviour
{
    public Character character;
    
   

    
    
    // Start is called before the first frame update
    void Start()
    {
        
      
        

        
    }

    public void OnSelectCharacter()          // Ŭ���� ȿ�� �ڵ� ���� ��
    {
        DataManager.instance.currentCharacter = character;

       

    }

   

   
}

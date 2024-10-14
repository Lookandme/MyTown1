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

    public void OnSelectCharacter()          // 클릭시 효과 코드 수정 중
    {
        DataManager.instance.currentCharacter = character;

       

    }

   

   
}

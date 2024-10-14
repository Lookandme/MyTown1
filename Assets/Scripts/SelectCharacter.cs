using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DataManager;


public class SelectCharacter : MonoBehaviour
{
    public Character character;
    public Image image;
   

    
    
    // Start is called before the first frame update
    void Start()
    {
        
      image = GetComponent<Image>();
        

        
    }

    public void OnSelectCharacter()          // 클릭시 효과 코드 수정 중
    {
        DataManager.instance.currentCharacter = character;

        if (DataManager.instance.currentCharacter != character) DeSelectedColor();
        else SelectedColor();

    }

    private void DeSelectedColor()
    {
        image.color = new Color(0.5f, 0.5f, 0.5f);
    }

    private void SelectedColor()
    {
        image.color = new Color(1f,1f,1f);
        
    }

   
}

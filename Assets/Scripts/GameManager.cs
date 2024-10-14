using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static DataManager;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab; // 생성할 플레이어 프리팹
    public CameraObject cam;
    public  TMP_Text tMP_Text;
    public SpriteRenderer renderer;
  



    private void Awake()
    {
       
    }
    void Start()
    {


        

        ChracterSettting();
    }





    private void ChracterSettting()
    {
        string playerName = PlayerPrefs.GetString("playerName", "Defult");
        string prefabName = DataManager.instance.currentCharacter.ToString();
        GameObject prefab = Resources.Load(prefabName) as GameObject;
        GameObject player = Instantiate(prefab, Vector3.zero, Quaternion.identity);



        TMP_Text tMP_Text = player.GetComponentInChildren<TMP_Text>();
       Renderer renderer = player.GetComponent<Renderer>();
       
        player.name = playerName;
        tMP_Text.text = playerName;
        cam.SetTaget(player);
    }

   
    
}

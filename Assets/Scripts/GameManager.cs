using UnityEngine;

public class MainMap : MonoBehaviour
{
    public GameObject playerPrefab; // 생성할 플레이어 프리팹
    public CameraObject cam;
    

    void Start()
    {
        // PlayerPrefs에서 이름 가져오기
        string playerName = PlayerPrefs.GetString("PlayerName", "DefaultName");

        // 플레이어 오브젝트 생성
        GameObject player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);

        // 플레이어 오브젝트의 이름 설정
        player.name = playerName;
        cam.SetTaget(player);
    }
}

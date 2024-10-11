using UnityEngine;

public class MainMap : MonoBehaviour
{
    public GameObject playerPrefab; // ������ �÷��̾� ������
    public CameraObject cam;
    

    void Start()
    {
        // PlayerPrefs���� �̸� ��������
        string playerName = PlayerPrefs.GetString("PlayerName", "DefaultName");

        // �÷��̾� ������Ʈ ����
        GameObject player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);

        // �÷��̾� ������Ʈ�� �̸� ����
        player.name = playerName;
        cam.SetTaget(player);
    }
}

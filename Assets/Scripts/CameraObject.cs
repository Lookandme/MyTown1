using UnityEngine;

public class CameraObject : MonoBehaviour
{
   [SerializeField] private GameObject Taget;
    private float followSpeed;
    private float cameraRotationZ;

    private Transform tagetTransform;
    private Transform thisTrnansform;

    private void Awake()
    {
       tagetTransform = Taget.GetComponent<Transform>();
        thisTrnansform = GetComponent<Transform>();

        followSpeed = 4.0f;
        cameraRotationZ = -10.0f;
    }



    private void Update()
    {
        thisTrnansform.position =  Vector2.Lerp(thisTrnansform.position, tagetTransform.position, followSpeed * Time.deltaTime);
        thisTrnansform.Translate(0,0, cameraRotationZ);
    }
    

}


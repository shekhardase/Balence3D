using UnityEngine;

public class camerafollow : MonoBehaviour
{

public GameObject plaer;



 void LateUpdate() {

    gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0 , gameObject.transform.position.y , plaer.gameObject.transform.position.z - 10),Time.deltaTime *100);
    
}
}
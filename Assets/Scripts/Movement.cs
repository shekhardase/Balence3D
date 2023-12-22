using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    // [SerializeField]  float speed = 5f;
    [SerializeField]  float ImpulseForce = 5f;
    [SerializeField] Rigidbody ball;
    // [SerializeField] float jumpForce = 5f;
    [SerializeField] float Xinput = 5f;
    [SerializeField] float Yinput = 5f;


    //  void Awake() {
      

    // }
    void Start()
    {  ball = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Stop();
        }
    }

  
  void FixedUpdate() {
    move();
    
  }

  void ProcessInput() {
    Xinput = Input.GetAxis("Horizontal");
    Yinput = Input.GetAxis("Vertical");
  }


 void move()
 {
    ball.AddForce(new Vector3(Xinput, 0f, Yinput) * ImpulseForce);
 }

 void Stop()
  {
      ball.velocity = Vector3.zero;
  }
  
}

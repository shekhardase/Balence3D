using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerExit(Collider other) {
        if (other.gameObject == _player) {
            Debug.Log("Player Hit");
        }
    }
}

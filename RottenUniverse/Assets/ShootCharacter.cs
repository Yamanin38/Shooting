using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Zが入力されました");
        }
    }
}

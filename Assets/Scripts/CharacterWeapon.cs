using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterWeapon : MonoBehaviour
{
    public GameObject arrow;
    public Camera playerCamera;
    public float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnFire(InputValue value) 
    {
        if (value != null)
        {
            GameObject arrowObject = Instantiate(arrow, playerCamera.transform.position + playerCamera.transform.forward + (Vector3.down * 0.5f), playerCamera.transform.rotation);
            Rigidbody rb = arrowObject.GetComponent<Rigidbody>();
            rb.velocity = playerCamera.transform.forward * speed;
        }
    }
}

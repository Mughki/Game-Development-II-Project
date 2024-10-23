using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goblin") || other.CompareTag("Armored Goblin"))
        {
            Enemy goblin = other.GetComponent<Enemy>();

            if (goblin != null)
            {
                goblin.OnHit();
                Destroy(gameObject);
            }
        }
    }
}

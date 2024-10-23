using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject keyPrefab;

    public void DropKey()
    {
        Vector3 position = transform.position + new Vector3(0f, 1f, 0f);
        Instantiate(keyPrefab, position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}

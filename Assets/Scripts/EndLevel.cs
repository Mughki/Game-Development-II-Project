using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public string scene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameObject.FindWithTag("Armored Goblin") == null && GameObject.FindWithTag("Key") == null)
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
}

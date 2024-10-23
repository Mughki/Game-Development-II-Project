using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int health = 1;
    public Key key;

    public void OnHit()
    {
        health--;

        if (health <= 0)
        {
            GetComponent<FollowPath>().enabled = false;
            animator.SetTrigger("Die");

            if (gameObject.CompareTag("Armored Goblin") && key != null)
            {
                key.DropKey();
            }

            Destroy(gameObject, 1.5f);
        }
    }
}

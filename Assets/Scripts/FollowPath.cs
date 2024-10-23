using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public Animator animator;
    public GameObject path;
    public float speed;
    private Vector3 nextWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetTrigger("Move");
        nextWaypoint = GetNextWaypoint();
        Vector3 targetDirection = nextWaypoint - transform.position;
        transform.rotation = Quaternion.LookRotation(targetDirection, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == nextWaypoint)
        {
            nextWaypoint = GetNextWaypoint();
            Vector3 targetDirection = nextWaypoint - transform.position;
            transform.rotation = Quaternion.LookRotation(targetDirection, Vector3.up);
        }

        transform.position = Vector3.MoveTowards(transform.position, nextWaypoint, Time.deltaTime * speed);
    }

    private Vector3 GetNextWaypoint()
    {
        return path.GetComponent<PathGuide>().NextWayPoint;
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float turnSpeed;
    Quaternion rotGoal;
    Vector3 direction;
    void Update()
    {
        direction = (target.position - transform.position).normalized;
        rotGoal = Quaternion.LookRotation(direction/4);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotGoal, turnSpeed);
    }
}
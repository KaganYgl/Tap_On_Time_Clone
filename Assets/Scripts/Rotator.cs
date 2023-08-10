using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed = 200;

    private Vector3 direction = Vector3.forward;

    private void Update()
    {
        transform.RotateAround(target.transform.position, direction, speed * Time.deltaTime * -1);
    }
}

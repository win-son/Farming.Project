using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform _target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _target = FindAnyObjectByType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_target.position.x, _target.position.y, transform.position.z);
    }
}

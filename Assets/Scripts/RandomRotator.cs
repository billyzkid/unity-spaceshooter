using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float tumble;

    private void Start()
    {
        var rb = GetComponent<Rigidbody>();

        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}
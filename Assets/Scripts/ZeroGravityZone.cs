using UnityEngine;

public class ZeroGravityZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = false;
            Debug.Log($"{other.gameObject.name} ����� � ���� �����������.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = true;
            Debug.Log($"{other.gameObject.name} ������� ���� �����������.");
        }
    }
}

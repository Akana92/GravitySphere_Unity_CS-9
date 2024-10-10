using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CueBallController : MonoBehaviour
{
    [Header("��������� ��������")]
    [Tooltip("���� ��������, ����������� � �����")]
    public float impulseForce = 500f;

    [Header("����������� ��������")]
    [Tooltip("����������� �������� � ��������� �����������")]
    public Vector3 impulseDirection = Vector3.forward;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            // ����������� �����������
            Vector3 direction = transform.TransformDirection(impulseDirection.normalized);
            // ��������� �������
            rb.AddForce(direction * impulseForce, ForceMode.Impulse);
            Debug.Log("����� ������� � �����: " + impulseForce + " � �����������: " + direction);
        }
        else
        {
            Debug.LogError("Rigidbody �� ������ �� �����!");
        }
    }
}

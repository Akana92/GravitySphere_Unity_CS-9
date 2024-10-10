using UnityEngine;

public class Superman : MonoBehaviour
{
    [Header("��������� ����")]
    [Tooltip("���� �����, ����������� � �������")]
    public float force = 500f;

    void OnCollisionEnter(Collision collision)
    {
        // �������� ���� �������, � ������� ��������� ������������
        int otherLayer = collision.gameObject.layer;
        string otherLayerName = LayerMask.LayerToName(otherLayer);

        // �������: ������� ��� ���� � �������
        Debug.Log($"Superman ���������� � ��������: {collision.gameObject.name}, ����: {otherLayerName}");

        // ���������, �������� �� ������ BadGuy
        if (otherLayerName == "BadGuy")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // ��������� ����������� �� Superman � �������
                Vector3 direction = (collision.gameObject.transform.position - transform.position).normalized;

                // ��������� ����
                rb.AddForce(direction * force);

                // ������� ��������� � ������� (��� �������)
                Debug.Log($"Superman ������ BadGuy ({collision.gameObject.name}) � �����: {force}");
            }
            else
            {
                Debug.LogWarning($"������ {collision.gameObject.name} �� ���� BadGuy �� ����� Rigidbody.");
            }
        }
        else
        {
            Debug.Log($"������������ � �������� {collision.gameObject.name}, ������� �� �������� BadGuy. �������� �� ���������.");
        }
    }
}

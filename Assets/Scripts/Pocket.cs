using UnityEngine;

public class Pocket : MonoBehaviour
{
    [Header("��������� �����")]
    [Tooltip("������ ������� ����� ��������� � ����� (��������, ������ ������)")]
    public GameObject pocketEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BilliardBall"))
        {
            // �� ������ �������� ���������� ������� ��� ����� �����
            if (pocketEffect != null)
            {
                Instantiate(pocketEffect, other.transform.position, Quaternion.identity);
            }

            // ������� ��� �� �����
            Destroy(other.gameObject);
            Debug.Log("��� " + other.name + " ����� � �����!");
        }
    }
}

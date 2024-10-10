using UnityEngine;

public class PipeBuilder : MonoBehaviour
{
    [Header("��������� �����")]
    public int segments = 72; // ���������� ���������
    public float radius = 3f; // ������ �����
    public Vector3 size = new Vector3(0.2f, 11f, 0.2f); // ������� ������� ��������
    public Material pipeMaterial; // �������� �����
    public Material floorMaterial; // �������� ����

    void Start()
    {
        if (pipeMaterial == null)
        {
            Debug.LogError("Pipe Material �� ��������!");
            return;
        }

        if (floorMaterial == null)
        {
            Debug.LogError("Floor Material �� ��������!");
            return;
        }

        float angleStep = 360f / segments;
        for (int i = 0; i < segments; i++)
        {
            float angle = i * angleStep * Mathf.Deg2Rad;
            Vector3 position = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius);
            GameObject segment = GameObject.CreatePrimitive(PrimitiveType.Cube);
            segment.transform.parent = transform;
            segment.transform.localScale = size;
            segment.transform.position = position;
            segment.transform.Rotate(0, angle * Mathf.Rad2Deg, 0);

            // ���������� ���������
            Renderer renderer = segment.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material = pipeMaterial;
            }

            // ���������, ��� ��������� ������������ (�� ��������� �����������)
        }

        // �������� �������� ���� ������ �����
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
        floor.transform.parent = transform;
        floor.transform.localScale = new Vector3(radius * 2, 0.1f, radius * 2);
        floor.transform.position = new Vector3(0, -size.y / 2, 0); // ����������� ��� ����� �����
        floor.transform.rotation = Quaternion.identity;

        Renderer floorRenderer = floor.GetComponent<Renderer>();
        if (floorRenderer != null)
        {
            floorRenderer.material = floorMaterial;
        }

        // ��� �������������, �������� Collider � ���� (��� ������������)
    }
}

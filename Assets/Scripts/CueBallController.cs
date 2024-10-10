using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CueBallController : MonoBehaviour
{
    [Header("Настройки импульса")]
    [Tooltip("Сила импульса, применяемая к битку")]
    public float impulseForce = 500f;

    [Header("Направление импульса")]
    [Tooltip("Направление импульса в локальных координатах")]
    public Vector3 impulseDirection = Vector3.forward;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Нормализуем направление
            Vector3 direction = transform.TransformDirection(impulseDirection.normalized);
            // Применяем импульс
            rb.AddForce(direction * impulseForce, ForceMode.Impulse);
            Debug.Log("Биток запущен с силой: " + impulseForce + " в направлении: " + direction);
        }
        else
        {
            Debug.LogError("Rigidbody не найден на битке!");
        }
    }
}

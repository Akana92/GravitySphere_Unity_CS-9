using UnityEngine;

public class Superman : MonoBehaviour
{
    [Header("Настройки силы")]
    [Tooltip("Сила удара, применяемая к объекту")]
    public float force = 500f;

    void OnCollisionEnter(Collision collision)
    {
        // Получаем слой объекта, с которым произошло столкновение
        int otherLayer = collision.gameObject.layer;
        string otherLayerName = LayerMask.LayerToName(otherLayer);

        // Отладка: выводим имя слоя и объекта
        Debug.Log($"Superman столкнулся с объектом: {collision.gameObject.name}, слой: {otherLayerName}");

        // Проверяем, является ли объект BadGuy
        if (otherLayerName == "BadGuy")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Вычисляем направление от Superman к объекту
                Vector3 direction = (collision.gameObject.transform.position - transform.position).normalized;

                // Применяем силу
                rb.AddForce(direction * force);

                // Выводим сообщение в консоль (для отладки)
                Debug.Log($"Superman ударил BadGuy ({collision.gameObject.name}) с силой: {force}");
            }
            else
            {
                Debug.LogWarning($"Объект {collision.gameObject.name} на слое BadGuy не имеет Rigidbody.");
            }
        }
        else
        {
            Debug.Log($"Столкновение с объектом {collision.gameObject.name}, который не является BadGuy. Действие не требуется.");
        }
    }
}

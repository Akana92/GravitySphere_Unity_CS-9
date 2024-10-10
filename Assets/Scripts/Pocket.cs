using UnityEngine;

public class Pocket : MonoBehaviour
{
    [Header("Настройки лунки")]
    [Tooltip("Префаб объекта после попадания в лунку (например, пустой объект)")]
    public GameObject pocketEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BilliardBall"))
        {
            // Вы можете добавить визуальные эффекты или звуки здесь
            if (pocketEffect != null)
            {
                Instantiate(pocketEffect, other.transform.position, Quaternion.identity);
            }

            // Удаляем шар из сцены
            Destroy(other.gameObject);
            Debug.Log("Шар " + other.name + " попал в лунку!");
        }
    }
}

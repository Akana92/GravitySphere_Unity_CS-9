using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float explosionForce = 1000f;
    public float explosionRadius = 5f;
    public float upwardsModifier = 0f;

    public void TriggerExplosion()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, upwardsModifier, ForceMode.Impulse);
            }
        }

        // Добавьте визуальные или звуковые эффекты взрыва здесь
        Debug.Log("Взрыв произошёл!");
    }

    // Например, вызвать взрыв по нажатию клавиши E
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TriggerExplosion();
        }
    }
}

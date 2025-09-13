using UnityEngine;

public class Collectable : MonoBehaviour {
    // How fast to spin the object
    public float rotationSpeed;

    // Effect for collecting items
    public GameObject onCollectEffect;

    // Update is called once per frame
    void Update() {
        transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed);
    }

    // RigidBody hits collider
    private void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Player")) return;
        
        // Destroy the collectible
        Destroy(gameObject);

        // creating particle effects
        // transform.position and transform.rotation sets the position of the particles to position of self.
        Instantiate(onCollectEffect, transform.position, transform.rotation);
    }
}
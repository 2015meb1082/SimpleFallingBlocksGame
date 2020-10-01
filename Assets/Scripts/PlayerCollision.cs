using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public event System.Action OnPlayerDeath;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FallingBlock")) {
            /*
            if (OnPlayerDeath != null) {
                OnPlayerDeath();
            }
            */
            OnPlayerDeath?.Invoke();
            Destroy(gameObject);
        }
    }
}

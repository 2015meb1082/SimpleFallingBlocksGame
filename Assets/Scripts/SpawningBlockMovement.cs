using UnityEngine;

public class SpawningBlockMovement : MonoBehaviour
{
    [SerializeField]
    private float blockSpeed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * blockSpeed *Time.deltaTime,Space.Self);        
    }
}

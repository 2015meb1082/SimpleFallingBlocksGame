using UnityEngine;

public class SpawningBlockMovement : MonoBehaviour
{
    [SerializeField]
    private Vector2 blockSpeedMinMax;
    private float blockSpeed;
    private float visibleHeightThreshold;
    private void Start()
    {
        blockSpeed = Mathf.Lerp(blockSpeedMinMax.x, blockSpeedMinMax.y, Difficulty.GetDifficultyPercent());
        visibleHeightThreshold = -Camera.main.orthographicSize - transform.localScale.y;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * blockSpeed *Time.deltaTime,Space.Self);

        if (transform.position.y < visibleHeightThreshold) {
            Destroy(gameObject);
        }
    }
}

using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    private float nextTimeToSpawn;
    [SerializeField]
    private float spawnWaitingTime=1.0f;

    private Camera mainCamera;
    [SerializeField]
    private  Vector2 screenHalfSizeInWorldUnits;
    [SerializeField]
    private GameObject objectToSpawn;
    [SerializeField]
    private Vector2 randomMinLimit;
    [SerializeField]
    private Vector2 randomMaxLimit;

    [SerializeField]
    private float minRotation=-10f;
    [SerializeField]
    private float maxRotation=10f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        screenHalfSizeInWorldUnits = new Vector2(mainCamera.aspect * mainCamera.orthographicSize,mainCamera.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTimeToSpawn) {
            SpawnBlock();
            nextTimeToSpawn = Time.time + spawnWaitingTime;
        }
    }
    private void SpawnBlock() {
        Vector3 randomScale = new Vector3(Random.Range(randomMinLimit.x, randomMaxLimit.x), Random.Range(randomMinLimit.y, randomMaxLimit.y),0);
        Vector2 randomPositionToSpawn = new Vector2(Random.Range(-screenHalfSizeInWorldUnits.x,screenHalfSizeInWorldUnits.x),screenHalfSizeInWorldUnits.y+ randomScale.y);
        Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(minRotation,maxRotation));
        GameObject obj = Instantiate(objectToSpawn,randomPositionToSpawn,randomRotation);
        obj.transform.localScale = randomScale;
        Destroy(obj, 4.0f);
    }
}

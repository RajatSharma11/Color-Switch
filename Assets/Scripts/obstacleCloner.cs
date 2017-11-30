using UnityEngine;

public class obstacleCloner : MonoBehaviour {

    public GameObject smallCirclePrefab;
    public GameObject smallCircleSpawnPoint;
    public GameObject smallRectanglePrefab;
    public GameObject smallRectangleSpawnPoint;
    public GameObject colorChangerPrefab;
    public GameObject colorChangerSpawnPoint;
    public GameObject pointPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Spawn")
        {
            // Clone the obstacle object
            int ran = Random.Range(0, 2);

            if (ran == 0)
            {
                // Small Circle
                Instantiate(smallCirclePrefab, smallCircleSpawnPoint.transform.position, smallCircleSpawnPoint.transform.rotation);
                Instantiate(colorChangerPrefab, colorChangerSpawnPoint.transform.position, colorChangerSpawnPoint.transform.rotation);
                Instantiate(pointPrefab, smallCircleSpawnPoint.transform.position, smallCircleSpawnPoint.transform.rotation);

            }
            else if(ran == 1)
            {
                // Small Rectangle
                Instantiate(smallRectanglePrefab, smallRectangleSpawnPoint.transform.position, smallRectangleSpawnPoint.transform.rotation);
                Instantiate(colorChangerPrefab, colorChangerSpawnPoint.transform.position, colorChangerSpawnPoint.transform.rotation);
                Instantiate(pointPrefab, smallRectangleSpawnPoint.transform.position, smallRectangleSpawnPoint.transform.rotation);

            }
        }
    }
}

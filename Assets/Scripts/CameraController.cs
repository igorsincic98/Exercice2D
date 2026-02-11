using UnityEngine;

public class CameraController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spawner"))
        {
            LevelManager.SpawnPoints.Add(other.transform);
        }

        if (other.CompareTag("Waypoint"))
        {
            LevelManager.WayPoints.Add(other.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Spawner"))
        {
            LevelManager.SpawnPoints.Remove(other.transform);
        }

        if (other.CompareTag("Waypoint"))
        {
            LevelManager.WayPoints.Remove(other.transform);
        }
    }
}

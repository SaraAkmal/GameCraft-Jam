using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class CollectableSpawner : MonoBehaviour
{
    [SerializeField] private GameObject collectable;

    private void Start()
    {
        SpawCollectables();
    }
    // Get Random Point on a Navmesh surface

    public Vector3 RandomNavmeshLocation(float radius)
    {
        var randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        NavMeshHit hit;
        var finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1)) finalPosition = hit.position;
        print(finalPosition);
        return finalPosition;
    }

    private void SpawCollectables()
    {
        for (var i = 0; i < 10; i++)
        {
            var randomPos = RandomNavmeshLocation(30);
            Instantiate(collectable, new Vector3(randomPos.x, 2.06f, randomPos.z), quaternion.identity);
        }
    }
}
using System.Collections;
using UnityEngine;

namespace Game
{
    public class PipeSpawner : MonoBehaviour
    {
        [SerializeField] private Pipe pipePrefab;
        [SerializeField] private float spawnInterval;
        [SerializeField] private float spawnRange;
        [SerializeField] private float destroyTime;

        private void Start()
        {
            StartCoroutine(IESpawnPipe());
        }

        private IEnumerator IESpawnPipe()
        {
            var timeWait = new WaitForSeconds(spawnInterval);

            while (true)
            {
                var pipe = Instantiate(pipePrefab, transform);
                pipe.transform.localPosition = Vector3.up * Random.Range(-spawnRange, spawnRange);
                Destroy(pipe.gameObject, destroyTime);

                yield return timeWait;
            }
        }
    }
}
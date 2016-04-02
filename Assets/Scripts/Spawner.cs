using UnityEngine;

namespace Assets.Scripts
{
    public class Spawner : MonoBehaviour
    {
        public float MinSpawnDelay;
        public float MaxSpawnDelay;

        private float _currentSpawnDelay;

        public GameObject GameObject;

        void Start()
        {
            _currentSpawnDelay = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        }

        void Update()
        {
            _currentSpawnDelay -= Time.deltaTime;

            if (_currentSpawnDelay <= 0)
            {
                _currentSpawnDelay = Random.Range(MinSpawnDelay, MaxSpawnDelay);
                Instantiate(GameObject);
            }
        }
    }
}
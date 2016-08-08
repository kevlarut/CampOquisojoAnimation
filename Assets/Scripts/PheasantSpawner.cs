using UnityEngine;

namespace Assets.Scripts
{
    public class PhesantSpa : MonoBehaviour
    {
        public float MinSpawnDelay;
        public float MaxSpawnDelay;

        private float _currentSpawnDelay;

        public GameObject SeagullGameObject;

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
                Instantiate(SeagullGameObject);
            }
        }
    }
}
using UnityEngine;

namespace Assets.Scripts
{
    public class Paddleboarder : MonoBehaviour
    {
        public float Speed;

        // Use this for initialization
        void Start()
        {            
            var y = Random.Range(-0.75f, -0.25f);
            transform.Translate(-5f, y, 0);
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Speed * Time.deltaTime, 0, 0);
            
            if (transform.position.x > 4)
            {
                Destroy(gameObject);
            }
        }
    }
}
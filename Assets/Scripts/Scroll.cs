using UnityEngine;

namespace Assets.Scripts
{
    public class Scroll : MonoBehaviour
    {
        public float Speed;

        // Use this for initialization
        void Start()
        {            
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(0, Speed * Time.deltaTime, 0);
        }
    }
}
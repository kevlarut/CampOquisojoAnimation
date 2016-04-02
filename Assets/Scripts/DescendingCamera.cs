using UnityEngine;

namespace Assets.Scripts
{
    public class DescendingCamera : MonoBehaviour
    {
        public float Speed;

        // Use this for initialization
        void Start()
        {            
			transform.Translate(0, 6.25f, 0);
        }

        // Update is called once per frame
        void Update()
        {
			if (transform.position.y > 0) {
            	transform.Translate(0, Speed * Time.deltaTime * -1, 0);
				if (transform.position.y < 0) {
					transform.Translate(0, 0, 0);
				}
			}
        }
    }
}
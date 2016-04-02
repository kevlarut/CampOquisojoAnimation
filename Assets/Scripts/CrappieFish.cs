using UnityEngine;

namespace Assets.Scripts
{
    public class CrappieFish : MonoBehaviour
    {
        public GameObject SplashGameObject;
        
		private Rigidbody2D _rigidbody;
        private float _startingY = 0;   

        // Use this for initialization
        void Start()
        {         		
            var x = Random.Range(-3.25f, 0f);
            var y = Random.Range(-1.75f, -1f);
            transform.Translate(x, y, 0);
            	
			_rigidbody = GetComponent<Rigidbody2D>();
            _startingY = transform.position.y;
			
            var force = Random.Range(1f, 5f);
			_rigidbody.AddForce(new Vector2(force, force), ForceMode2D.Impulse);
            
           var splash = Instantiate(SplashGameObject);
           splash.transform.Translate(transform.position.x, transform.position.y, 0);
        }

        // Update is called once per frame
        void Update()
        {           
			Vector2 v = _rigidbody.velocity;
 			var angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
 			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
			
            if (transform.position.y < _startingY)
            {
                var splash = Instantiate(SplashGameObject);
                splash.transform.Translate(transform.position.x, transform.position.y, 0);
                
                Destroy(gameObject);
            }
        }
    }
}
using UnityEngine;

namespace Assets.Scripts
{
    public class Fade : MonoBehaviour
    {
        public float DelayBeforeShowing;
        public float TimeToLive;
        public float FadeSpeed;
        
        private SpriteRenderer _spriteRenderer;
        private float _alpha = 1f;
        private float _timeToLiveRemaining = 0f;
        private float _delayBeforeShowingRemaining = 0f;

        // Use this for initialization
        void Start ()
        {
            _delayBeforeShowingRemaining = DelayBeforeShowing;
            _timeToLiveRemaining = TimeToLive;
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }
	
        // Update is called once per frame
        void Update ()
        {
            if (_delayBeforeShowingRemaining > 0f)
            {
                SetAlpha(0f);
                _delayBeforeShowingRemaining -= Time.deltaTime;
                if (_delayBeforeShowingRemaining <= 0f)
                {
                    SetAlpha(1f);
                }
            }
            else
            {
                if (_timeToLiveRemaining > 0f)
                {
                    _timeToLiveRemaining -= Time.deltaTime;
                }
                else
                {
                    _alpha -= FadeSpeed*Time.deltaTime;
                    SetAlpha(_alpha);
                }
            }
        }

        private void SetAlpha(float alpha)
        {
            var color = _spriteRenderer.material.color;
            color.a = alpha;
            _spriteRenderer.material.color = color;
        }
    }
}

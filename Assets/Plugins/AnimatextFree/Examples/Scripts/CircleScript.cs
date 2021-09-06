using UnityEngine;

namespace AnimatextFree.Examples
{
    public class CircleScript : MonoBehaviour
    {
        private RectTransform rectTransform;

        public float amplitude = 0.05f;

        private void Start()
        {
            rectTransform = GetComponent<RectTransform>();
        }

        private void Update()
        {
            rectTransform.localScale = Vector3.one * (1 + amplitude * Mathf.Sin(Time.time * Mathf.PI * 0.25f - Mathf.PI * 0.5f));
        }
    }
}


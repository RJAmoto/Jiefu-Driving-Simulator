using UnityEngine;
using UnityEngine.UI;

namespace AnimatextFree.Examples
{
    [DefaultExecutionOrder(-100)]
    [RequireComponent(typeof(Text))]
    public class TextScript : BaseExampleScript
    {
        private Text textComponent;
        [TextArea]public string text;

        private void Start()
        {
            textComponent = GetComponent<Text>();
            textComponent.text = text;
        }
    }
}

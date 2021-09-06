using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class QuickStartScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;

        public BaseEffect preset;

        private void Start()
        {
            AddAnimatextEffect(textB, new Effect(preset, generalParamGroup));
            AddAnimatextComponent(textC, new Effect(preset, generalParamGroup));
            AddAnimatextComponent(textD, new Effect(preset, generalParamGroup), false);
        }
    }
}
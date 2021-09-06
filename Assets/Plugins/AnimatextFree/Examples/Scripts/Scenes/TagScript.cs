using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class TagScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;
        public GameObject textE;

        private void Start()
        {
            TLBasicA01 preset = ScriptableObject.CreateInstance<TLBasicA01>();

            preset.singleTime = 2f;
            preset.interval = 0f;
            preset.loopInterval = 1f;
            preset.position = new Vector2(0, 30);

            AddAnimatextComponent(textA, new Effect(preset, generalParamGroup), false);
            AddAnimatextComponent(textB, new Effect(preset, generalParamGroup), false);
            AddAnimatextComponent(textC, new Effect(preset, generalParamGroup), false);
            AddAnimatextComponent(textD, new Effect(preset, generalParamGroup), false);
            AddAnimatextComponent(textE, new Effect(preset, generalParamGroup), false);
        }
    }
}
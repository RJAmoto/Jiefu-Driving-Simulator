using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class EffectTagScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;

        private void Start()
        {
            TLBasicA01 preset = ScriptableObject.CreateInstance<TLBasicA01>();
            preset.interval = 1f;
            preset.loopInterval = 3f;
            preset.position = new Vector2(0, 30);

            AddAnimatextComponent(textA, new Effect(preset, generalParamGroup), false);
            AddAnimatextComponent(textB, new Effect(preset, generalParamGroup), false);
            AddAnimatextComponent(textC, new Effect(preset, generalParamGroup), false);
            AddAnimatextComponent(textD, new Effect(preset, generalParamGroup), false);
        }
    }
}
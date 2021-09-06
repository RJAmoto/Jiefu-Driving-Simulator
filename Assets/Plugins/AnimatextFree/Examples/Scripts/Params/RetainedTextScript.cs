using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class RetainedTextScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;
        public GameObject textE;

        private void Start()
        {
            TLBasicA05 preset = ScriptableObject.CreateInstance<TLBasicA05>();

            preset.singleTime = 2f;
            preset.loopInterval = 1f;

            AddAnimatextComponent(textA, new Effect(preset, generalParamGroup), RetainedText.InputText);
            AddAnimatextComponent(textB, new Effect(preset, generalParamGroup), RetainedText.ParsedText);
            AddAnimatextComponent(textC, new Effect(preset, generalParamGroup), RetainedText.OutputText);
            AddAnimatextComponent(textD, new Effect(preset, generalParamGroup), RetainedText.EffectText);
            AddAnimatextComponent(textE, new Effect(preset, generalParamGroup), RetainedText.BlankText);
        }
    }
}
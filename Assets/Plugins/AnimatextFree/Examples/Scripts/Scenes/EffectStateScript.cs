using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class EffectStateScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;
        public GameObject textE;

        private void Start()
        {
            AnimatextFreeUGUI animatextA;
            AnimatextFreeUGUI animatextB;
            AnimatextFreeUGUI animatextC;
            AnimatextFreeUGUI animatextD;
            AnimatextFreeUGUI animatextE;

            TLBasicA01 preset = ScriptableObject.CreateInstance<TLBasicA01>();

            preset.singleTime = 2f;
            preset.loopInterval = 1f;
            preset.position = new Vector2(0, 30);

            GeneralParamGroup paramGroup = new GeneralParamGroup();
            paramGroup.tag = generalParamGroup.tag;

            AddAnimatextComponent(textA, new Effect(preset, paramGroup), out animatextA);
            AddAnimatextComponent(textB, new Effect(preset, paramGroup), out animatextB);
            AddAnimatextComponent(textC, new Effect(preset, paramGroup), out animatextC);
            AddAnimatextComponent(textD, new Effect(preset, paramGroup), out animatextD);
            AddAnimatextComponent(textE, new Effect(preset, paramGroup), out animatextE);

            animatextB.StartEffect(0);

            animatextC.PlayEffect(0);

            animatextD.effects[0].time = 0.5f;
            animatextD.PlayEffect(0);
            animatextD.PauseEffect(0);

            animatextE.EndEffect(0);
        }
    }
}
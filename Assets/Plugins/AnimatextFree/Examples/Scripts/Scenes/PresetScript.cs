using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class PresetScript : BaseExampleScript
    {
        public GameObject textA1;
        public GameObject textA2;
        public GameObject textA3;
        public GameObject textA4;

        public GameObject textB1;
        public GameObject textB2;

        public GameObject textC1;
        public GameObject textC2;
        public GameObject textC3;

        private void Start()
        {
            TCBasicA05 presetA1 = ScriptableObject.CreateInstance<TCBasicA05>();

            presetA1.singleTime = 0.1f;
            presetA1.interval = 0.1f;
            presetA1.loopInterval = 1f;

            AddAnimatextComponent(textA1, new Effect(presetA1, generalParamGroup));

            TWBasicA05 presetA2 = ScriptableObject.CreateInstance<TWBasicA05>();

            presetA2.singleTime = 0.2f;
            presetA2.interval = 1f;
            presetA2.loopInterval = 1f;

            AddAnimatextComponent(textA2, new Effect(presetA2, generalParamGroup));

            TLBasicA05 presetA3 = ScriptableObject.CreateInstance<TLBasicA05>();

            presetA3.singleTime = 0.2f;
            presetA3.interval = 1.2f;
            presetA3.loopInterval = 2f;

            AddAnimatextComponent(textA3, new Effect(presetA3, generalParamGroup));

            TGBasicA05 presetA4 = ScriptableObject.CreateInstance<TGBasicA05>();

            presetA4.singleTime = 0.2f;
            presetA4.interval = 0.5f;
            presetA4.loopInterval = 1f;

            AddAnimatextComponent(textA4, new Effect(presetA4, generalParamGroup));

            TLBasicA01 presetB1 = ScriptableObject.CreateInstance<TLBasicA01>();

            presetB1.singleTime = 1.2f;
            presetB1.interval = 1.2f;
            presetB1.loopInterval = 1f;
            presetB1.position = new Vector2(0, 30);

            AddAnimatextComponent(textB1, new Effect(presetB1, generalParamGroup));

            CLBasicA01 presetB2 = ScriptableObject.CreateInstance<CLBasicA01>();

            presetB2.singleTime = 1.2f;
            presetB2.interval = 1.2f;
            presetB2.loopInterval = 1f;
            presetB2.position = new Vector2(0, 30);
            presetB2.continuousEasing = true;

            AddAnimatextComponent(textB2, new Effect(presetB2, generalParamGroup));

            TLBasicA01 presetC1 = ScriptableObject.CreateInstance<TLBasicA01>();

            presetC1.singleTime = 1.2f;
            presetC1.interval = 1.2f;
            presetC1.loopInterval = 1f;
            presetC1.position = new Vector2(0, 30);

            AddAnimatextComponent(textC1, new Effect(presetC1, generalParamGroup));

            TLBounceA03 presetC2 = ScriptableObject.CreateInstance<TLBounceA03>();

            presetC2.singleTime = 1.2f;
            presetC2.interval = 1.2f;
            presetC2.loopInterval = 1f;

            AddAnimatextComponent(textC2, new Effect(presetC2, generalParamGroup));

            TLElasticA02 presetC3 = ScriptableObject.CreateInstance<TLElasticA02>();

            presetC3.singleTime = 1.2f;
            presetC3.interval = 1.2f;
            presetC3.loopInterval = 1f;
            presetC3.rotation = 15;
            presetC3.stiffness = 3;

            AddAnimatextComponent(textC3, new Effect(presetC3, generalParamGroup));
        }
    }
}
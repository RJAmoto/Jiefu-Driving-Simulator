using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class UnitTagScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;

        private void Start()
        {
            TCBasicA05 presetA = ScriptableObject.CreateInstance<TCBasicA05>();

            presetA.singleTime = 0.1f;
            presetA.interval = 0.3f;
            presetA.loopInterval = 1.2f;

            AddAnimatextComponent(textA, new Effect(presetA, generalParamGroup));


            TWBasicA05 presetB = ScriptableObject.CreateInstance<TWBasicA05>();

            presetB.singleTime = 0.1f;
            presetB.interval = 0.6f;
            presetB.loopInterval = 1.5f;

            AddAnimatextComponent(textB, new Effect(presetB, generalParamGroup));


            TLBasicA05 presetC = ScriptableObject.CreateInstance<TLBasicA05>();

            presetC.singleTime = 0.1f;
            presetC.interval = 0.9f;
            presetC.loopInterval = 1.8f;

            AddAnimatextComponent(textC, new Effect(presetC, generalParamGroup));


            TGBasicA05 presetD = ScriptableObject.CreateInstance<TGBasicA05>();

            presetD.singleTime = 0.1f;
            presetD.interval = 0.6f;
            presetD.loopInterval = 1.5f;

            AddAnimatextComponent(textD, new Effect(presetD, generalParamGroup));
        }
    }
}
using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class BouncesScript : BaseExampleScript
    {
        public GameObject textA;
        public int bouncesA;

        public GameObject textB;
        public int bouncesB;

        public GameObject textC;
        public int bouncesC;

        private void Start()
        {
            TLBounceA03 presetA = ScriptableObject.CreateInstance<TLBounceA03>();

            presetA.singleTime = 2f;
            presetA.loopInterval = 1f;
            presetA.bounces = bouncesA;

            AddAnimatextComponent(textA, new Effect(presetA, generalParamGroup));


            TLBounceA03 presetB = ScriptableObject.CreateInstance<TLBounceA03>();

            presetB.singleTime = 2f;
            presetB.loopInterval = 1f;
            presetB.bounces = bouncesB;

            AddAnimatextComponent(textB, new Effect(presetB, generalParamGroup));


            TLBounceA03 presetC = ScriptableObject.CreateInstance<TLBounceA03>();

            presetC.singleTime = 2f;
            presetC.loopInterval = 1f;
            presetC.bounces = bouncesC;

            AddAnimatextComponent(textC, new Effect(presetC, generalParamGroup));
        }
    }
}
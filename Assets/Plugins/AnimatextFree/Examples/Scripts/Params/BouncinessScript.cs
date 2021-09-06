using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class BouncinessScript : BaseExampleScript
    {
        public GameObject textA;
        public float bouncinessA;

        public GameObject textB;
        public float bouncinessB;

        public GameObject textC;
        public float bouncinessC;

        private void Start()
        {
            TLBounceA03 presetA = ScriptableObject.CreateInstance<TLBounceA03>();

            presetA.singleTime = 2f;
            presetA.loopInterval = 1f;
            presetA.bounciness = bouncinessA;

            AddAnimatextComponent(textA, new Effect(presetA, generalParamGroup));


            TLBounceA03 presetB = ScriptableObject.CreateInstance<TLBounceA03>();

            presetB.singleTime = 2f;
            presetB.loopInterval = 1f;
            presetB.bounciness = bouncinessB;

            AddAnimatextComponent(textB, new Effect(presetB, generalParamGroup));


            TLBounceA03 presetC = ScriptableObject.CreateInstance<TLBounceA03>();

            presetC.singleTime = 2f;
            presetC.loopInterval = 1f;
            presetC.bounciness = bouncinessC;

            AddAnimatextComponent(textC, new Effect(presetC, generalParamGroup));
        }
    }
}
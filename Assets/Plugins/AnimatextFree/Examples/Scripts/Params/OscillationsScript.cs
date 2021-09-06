using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class OscillationsScript : BaseExampleScript
    {
        public GameObject textA;
        public int oscillationsA;

        public GameObject textB;
        public int oscillationsB;

        public GameObject textC;
        public int oscillationsC;

        private void Start()
        {
            TLElasticA02 presetA = ScriptableObject.CreateInstance<TLElasticA02>();

            presetA.singleTime = 2f;
            presetA.loopInterval = 1f;
            presetA.anchorOffset = new Vector2(0, -200);
            presetA.oscillations = oscillationsA;

            AddAnimatextComponent(textA, new Effect(presetA, generalParamGroup));


            TLElasticA02 presetB = ScriptableObject.CreateInstance<TLElasticA02>();

            presetB.singleTime = 2f;
            presetB.loopInterval = 1f;
            presetB.anchorOffset = new Vector2(0, -200);
            presetB.oscillations = oscillationsB;

            AddAnimatextComponent(textB, new Effect(presetB, generalParamGroup));


            TLElasticA02 presetC = ScriptableObject.CreateInstance<TLElasticA02>();

            presetC.singleTime = 2f;
            presetC.loopInterval = 1f;
            presetC.anchorOffset = new Vector2(0, -200);
            presetC.oscillations = oscillationsC;

            AddAnimatextComponent(textC, new Effect(presetC, generalParamGroup));
        }
    }
}
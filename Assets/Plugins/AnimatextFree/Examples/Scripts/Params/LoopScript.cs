using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class LoopScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;

        private void Start()
        {
            TCBasicA01 presetA = ScriptableObject.CreateInstance<TCBasicA01>();

            presetA.singleTime = 0.2f;
            presetA.interval = 0.2f;
            presetA.loopInterval = 1f;
            presetA.position = new Vector2(0, 30);
            presetA.pingpongLoop = true;
            presetA.continuousLoop = true;

            AddAnimatextComponent(textA, new Effect(presetA, generalParamGroup));


            TCBasicA01 presetB = ScriptableObject.CreateInstance<TCBasicA01>();

            presetB.singleTime = 0.2f;
            presetB.interval = 0.2f;
            presetB.loopInterval = 1f;
            presetB.position = new Vector2(0, 30);
            presetB.pingpongLoop = true;
            presetB.continuousLoop = false;

            AddAnimatextComponent(textB, new Effect(presetB, generalParamGroup));


            TCBasicA01 presetC = ScriptableObject.CreateInstance<TCBasicA01>();

            presetC.singleTime = 0.2f;
            presetC.interval = 0.2f;
            presetC.loopInterval = 1f;
            presetC.position = new Vector2(0, 30);
            presetC.pingpongLoop = false;
            presetC.continuousLoop = true;

            AddAnimatextComponent(textC, new Effect(presetC, generalParamGroup));


            TCBasicA01 presetD = ScriptableObject.CreateInstance<TCBasicA01>();

            presetD.singleTime = 0.2f;
            presetD.interval = 0.2f;
            presetD.loopInterval = 1f;
            presetD.position = new Vector2(0, 30);
            presetD.pingpongLoop = false;
            presetD.continuousLoop = false;

            AddAnimatextComponent(textD, new Effect(presetD, generalParamGroup));
        }
    }
}
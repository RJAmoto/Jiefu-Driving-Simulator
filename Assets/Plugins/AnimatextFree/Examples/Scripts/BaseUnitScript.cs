using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    [DefaultExecutionOrder(999)]
    public class BaseUnitScript : BaseExampleScript
    {
        public GameObject textA1;
        public GameObject textA2;
        public GameObject textA3;
        public GameObject textA4;

        public GameObject textB1;
        public GameObject textB2;
        public GameObject textB3;
        public GameObject textB4;

        public GameObject textC1;
        public GameObject textC2;
        public GameObject textC3;
        public GameObject textC4;

        public GameObject textD1;
        public GameObject textD2;
        public GameObject textD3;
        public GameObject textD4;

        protected UnitTemplateEffect presetA1;
        protected UnitTemplateEffect presetA2;
        protected UnitTemplateEffect presetA3;
        protected UnitTemplateEffect presetA4;

        protected UnitTemplateEffect presetB1;
        protected UnitTemplateEffect presetB2;
        protected UnitTemplateEffect presetB3;
        protected UnitTemplateEffect presetB4;

        protected UnitTemplateEffect presetC1;
        protected UnitTemplateEffect presetC2;
        protected UnitTemplateEffect presetC3;
        protected UnitTemplateEffect presetC4;

        protected UnitTemplateEffect presetD1;
        protected UnitTemplateEffect presetD2;
        protected UnitTemplateEffect presetD3;
        protected UnitTemplateEffect presetD4;

        protected float characterSingleTimeA = 0.95f;
        protected float characterIntervalA = 0.55f;
        protected float characterLoopIntervalA = 1f;

        protected float characterSingleTimeB = 0.95f;
        protected float characterIntervalB = 0.55f;
        protected float characterLoopIntervalB = 1f;

        protected float characterSingleTimeC = 1.5f;
        protected float characterIntervalC = 0.5f;
        protected float characterLoopIntervalC = 1f;

        protected float characterSingleTimeD = 1.5f;
        protected float characterIntervalD = 0.5f;
        protected float characterLoopIntervalD = 1f;

        protected float wordSingleTimeA = 1.5f;
        protected float wordIntervalA = 1.5f;
        protected float wordLoopIntervalA = 1f;

        protected float wordSingleTimeB = 1.5f;
        protected float wordIntervalB = 1.5f;
        protected float wordLoopIntervalB = 1f;

        protected float wordSingleTimeC = 2f;
        protected float wordIntervalC = 1f;
        protected float wordLoopIntervalC = 1f;

        protected float wordSingleTimeD = 2f;
        protected float wordIntervalD = 1f;
        protected float wordLoopIntervalD = 1f;

        protected float lineSingleTimeA = 1f;
        protected float lineIntervalA = 1f;
        protected float lineLoopIntervalA = 1f;

        protected float lineSingleTimeB = 1f;
        protected float lineIntervalB = 1f;
        protected float lineLoopIntervalB = 1f;

        protected float lineSingleTimeC = 1.25f;
        protected float lineIntervalC = 1f;
        protected float lineLoopIntervalC = 0.75f;

        protected float lineSingleTimeD = 1.25f;
        protected float lineIntervalD = 1f;
        protected float lineLoopIntervalD = 0.75f;

        protected float groupSingleTimeA = 0.75f;
        protected float groupIntervalA = 1.25f;
        protected float groupLoopIntervalA = 1f;

        protected float groupSingleTimeB = 0.75f;
        protected float groupIntervalB = 1.25f;
        protected float groupLoopIntervalB = 1f;

        protected float groupSingleTimeC = 1f;
        protected float groupIntervalC = 1f;
        protected float groupLoopIntervalC = 1f;

        protected float groupSingleTimeD = 1f;
        protected float groupIntervalD = 1f;
        protected float groupLoopIntervalD = 1f;

        protected EasingType easingTypeA = EasingType.Linear;
        protected EasingType easingTypeB = EasingType.QuadInOut;
        protected EasingType easingTypeC = EasingType.QuadOut;
        protected EasingType easingTypeD = EasingType.QuadOut;

        protected float fadeRangeEndValueA = 0.25f;
        protected float fadeRangeEndValueB = 0.25f;
        protected float fadeRangeEndValueC = 0.75f;
        protected float fadeRangeEndValueD = 0.75f;

        protected void AddAnimatextComponents()
        {
            presetA1.reverse = true;
            presetA1.pingpongLoop = false;
            presetA1.interval = characterIntervalA;
            presetA1.loopInterval = characterLoopIntervalA;
            presetA1.sortType = SortType.MiddleToSidesFront;
            AddAnimatextComponent(textA1, new Effect(presetA1, generalParamGroup));

            presetA2.reverse = false;
            presetA2.pingpongLoop = false;
            presetA2.interval = characterIntervalB;
            presetA2.loopInterval = characterLoopIntervalB;
            presetA2.sortType = SortType.SidesToMiddleBack;
            AddAnimatextComponent(textA2, new Effect(presetA2, generalParamGroup));

            presetA3.reverse = false;
            presetA3.pingpongLoop = false;
            presetA3.interval = characterIntervalC;
            presetA3.loopInterval = characterLoopIntervalC;
            presetA3.sortType = SortType.BackToFront;
            AddAnimatextComponent(textA3, new Effect(presetA3, generalParamGroup));

            presetA4.reverse = true;
            presetA4.pingpongLoop = false;
            presetA4.interval = characterIntervalD;
            presetA4.loopInterval = characterLoopIntervalD;
            presetA4.sortType = SortType.FrontToBack;
            AddAnimatextComponent(textA4, new Effect(presetA4, generalParamGroup));

            presetB1.reverse = true;
            presetB1.pingpongLoop = false;
            presetB1.interval = wordIntervalA;
            presetB1.loopInterval = wordLoopIntervalA;
            presetB1.sortType = SortType.BackToFront;
            AddAnimatextComponent(textB1, new Effect(presetB1, generalParamGroup));

            presetB2.reverse = false;
            presetB2.pingpongLoop = false;
            presetB2.interval = wordIntervalB;
            presetB2.loopInterval = wordLoopIntervalB;
            presetB2.sortType = SortType.FrontToBack;
            AddAnimatextComponent(textB2, new Effect(presetB2, generalParamGroup));

            presetB3.reverse = true;
            presetB3.pingpongLoop = true;
            presetB3.interval = wordIntervalC;
            presetB3.loopInterval = wordLoopIntervalC;
            presetB3.sortType = SortType.BackToFront;
            AddAnimatextComponent(textB3, new Effect(presetB3, generalParamGroup));

            presetB4.reverse = false;
            presetB4.pingpongLoop = true;
            presetB4.interval = wordIntervalD;
            presetB4.loopInterval = wordLoopIntervalD;
            presetB4.sortType = SortType.FrontToBack;
            AddAnimatextComponent(textB4, new Effect(presetB4, generalParamGroup));

            presetC1.reverse = true;
            presetC1.pingpongLoop = false;
            presetC1.interval = lineIntervalA;
            presetC1.loopInterval = lineLoopIntervalA;
            presetC1.sortType = SortType.FrontToBack;
            AddAnimatextComponent(textC1, new Effect(presetC1, generalParamGroup));

            presetC2.reverse = false;
            presetC2.pingpongLoop = false;
            presetC2.interval = lineIntervalB;
            presetC2.loopInterval = lineLoopIntervalB;
            presetC2.sortType = SortType.FrontToBack;
            AddAnimatextComponent(textC2, new Effect(presetC2, generalParamGroup));

            presetC3.reverse = true;
            presetC3.pingpongLoop = true;
            presetC3.interval = lineIntervalC;
            presetC3.loopInterval = lineLoopIntervalC;
            presetC3.sortType = SortType.FrontToBack;
            AddAnimatextComponent(textC3, new Effect(presetC3, generalParamGroup));

            presetC4.reverse = false;
            presetC4.pingpongLoop = true;
            presetC4.interval = lineIntervalD;
            presetC4.loopInterval = lineLoopIntervalD;
            presetC4.sortType = SortType.FrontToBack;
            AddAnimatextComponent(textC4, new Effect(presetC4, generalParamGroup));

            presetD1.reverse = true;
            presetD1.pingpongLoop = false;
            presetD1.interval = groupIntervalA;
            presetD1.loopInterval = groupLoopIntervalA;
            presetD1.sortType = SortType.FrontToMiddle;
            AddAnimatextComponent(textD1, new Effect(presetD1, generalParamGroup));

            presetD2.reverse = false;
            presetD2.pingpongLoop = false;
            presetD2.interval = groupIntervalB;
            presetD2.loopInterval = groupLoopIntervalB;
            presetD2.sortType = SortType.MiddleToBack;
            AddAnimatextComponent(textD2, new Effect(presetD2, generalParamGroup));

            presetD3.reverse = false;
            presetD3.pingpongLoop = false;
            presetD3.interval = groupIntervalC;
            presetD3.loopInterval = groupLoopIntervalC;
            presetD3.sortType = SortType.FrontToBack;
            AddAnimatextComponent(textD3, new Effect(presetD3, generalParamGroup));

            presetD4.reverse = true;
            presetD4.pingpongLoop = false;
            presetD4.interval = groupIntervalD;
            presetD4.loopInterval = groupLoopIntervalD;
            presetD4.sortType = SortType.BackToFront;
            AddAnimatextComponent(textD4, new Effect(presetD4, generalParamGroup));
        }
    }
}

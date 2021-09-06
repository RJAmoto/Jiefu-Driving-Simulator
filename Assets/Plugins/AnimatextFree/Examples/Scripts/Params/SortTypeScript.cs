using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class SortTypeScript : BaseExampleScript
    {
        public GameObject textA;
        public SortType sortTypeA;

        public GameObject textB;
        public SortType sortTypeB;

        public GameObject textC;
        public SortType sortTypeC;

        public GameObject textD;
        public SortType sortTypeD;

        public GameObject textE;
        public SortType sortTypeE;

        public GameObject textF;
        public SortType sortTypeF;

        public GameObject textG;
        public SortType sortTypeG;

        public GameObject textH;
        public SortType sortTypeH;

        public GameObject textI;
        public SortType sortTypeI;

        public GameObject textJ;
        public SortType sortTypeJ;

        private void Start()
        {
            TCBasicA05 presetA = ScriptableObject.CreateInstance<TCBasicA05>();

            presetA.singleTime = 0.1f;
            presetA.interval = 0.2f;
            presetA.loopInterval = 1f;
            presetA.sortType = sortTypeA;

            AddAnimatextComponent(textA, new Effect(presetA, generalParamGroup));


            TCBasicA05 presetB = ScriptableObject.CreateInstance<TCBasicA05>();

            presetB.singleTime = 0.1f;
            presetB.interval = 0.2f;
            presetB.loopInterval = 1f;
            presetB.sortType = sortTypeB;

            AddAnimatextComponent(textB, new Effect(presetB, generalParamGroup));


            TCBasicA05 presetC = ScriptableObject.CreateInstance<TCBasicA05>();

            presetC.singleTime = 0.1f;
            presetC.interval = 0.2f;
            presetC.loopInterval = 1f;
            presetC.sortType = sortTypeC;

            AddAnimatextComponent(textC, new Effect(presetC, generalParamGroup));


            TCBasicA05 presetD = ScriptableObject.CreateInstance<TCBasicA05>();

            presetD.singleTime = 0.1f;
            presetD.interval = 0.2f;
            presetD.loopInterval = 1f;
            presetD.sortType = sortTypeD;

            AddAnimatextComponent(textD, new Effect(presetD, generalParamGroup));


            TCBasicA05 presetE = ScriptableObject.CreateInstance<TCBasicA05>();

            presetE.singleTime = 0.1f;
            presetE.interval = 0.2f;
            presetE.loopInterval = 1f;
            presetE.sortType = sortTypeE;

            AddAnimatextComponent(textE, new Effect(presetE, generalParamGroup));


            TCBasicA05 presetF = ScriptableObject.CreateInstance<TCBasicA05>();

            presetF.singleTime = 0.1f;
            presetF.interval = 0.2f;
            presetF.loopInterval = 1f;
            presetF.sortType = sortTypeF;

            AddAnimatextComponent(textF, new Effect(presetF, generalParamGroup));


            TCBasicA05 presetG = ScriptableObject.CreateInstance<TCBasicA05>();

            presetG.singleTime = 0.1f;
            presetG.interval = 0.2f;
            presetG.loopInterval = 1f;
            presetG.sortType = sortTypeG;

            AddAnimatextComponent(textG, new Effect(presetG, generalParamGroup));


            TCBasicA05 presetH = ScriptableObject.CreateInstance<TCBasicA05>();

            presetH.singleTime = 0.1f;
            presetH.interval = 0.2f;
            presetH.loopInterval = 1f;
            presetH.sortType = sortTypeH;

            AddAnimatextComponent(textH, new Effect(presetH, generalParamGroup));


            TCBasicA05 presetI = ScriptableObject.CreateInstance<TCBasicA05>();

            presetI.singleTime = 0.1f;
            presetI.interval = 0.2f;
            presetI.loopInterval = 1f;
            presetI.sortType = sortTypeI;

            AddAnimatextComponent(textI, new Effect(presetI, generalParamGroup));


            TCBasicA05 presetJ = ScriptableObject.CreateInstance<TCBasicA05>();

            presetJ.singleTime = 0.1f;
            presetJ.interval = 0.2f;
            presetJ.loopInterval = 1f;
            presetJ.sortType = sortTypeJ;

            AddAnimatextComponent(textJ, new Effect(presetJ, generalParamGroup));
        }
    }
}
using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class NotationScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;

        private void Start()
        {
            TLBasicA05 preset = ScriptableObject.CreateInstance<TLBasicA05>();

            preset.singleTime = 2f;
            preset.loopInterval = 1f;

            AddAnimatextComponent(textA, new Effect(preset, generalParamGroup), TagSymbols.AngleBrackets, MarkerSymbols.Slashes);
            AddAnimatextComponent(textB, new Effect(preset, generalParamGroup), TagSymbols.RoundBrackets, MarkerSymbols.Slashes);
            AddAnimatextComponent(textC, new Effect(preset, generalParamGroup), TagSymbols.SquareBrackets, MarkerSymbols.Backslashes);
            AddAnimatextComponent(textD, new Effect(preset, generalParamGroup), TagSymbols.CurlyBrackets, MarkerSymbols.Backslashes);
        }
    }
}
using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class BackgroundTextScript : BaseExampleScript
    {
        public Vector2 position;
        public SortType sortType;

        private void Start()
        {
            CCBasicA01 preset = ScriptableObject.CreateInstance<CCBasicA01>();

            preset.singleTime = 8f;
            preset.interval = 2f;
            preset.continuousLoop = true;
            preset.position = position;
            preset.sortType = sortType;
            preset.continuousEasing = true;

            Effect effect = new Effect(preset, generalParamGroup);

            effect.time = 8f;

            AddAnimatextComponent(gameObject, effect);
        }
    }
}

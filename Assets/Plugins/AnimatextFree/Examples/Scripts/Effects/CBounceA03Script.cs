using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class CBounceA03Script : BaseUnitScript
    {
        private void Start()
        {
            CCBounceA03 A1 = ScriptableObject.CreateInstance<CCBounceA03>();

            A1.singleTime = characterSingleTimeA;
            A1.easingType = easingTypeA;
            A1.scale = new Vector2(0, 1);
            A1.anchorType = AnchorType.Top;
            A1.bounces = 1;
            A1.bounciness = 0.75f;

            presetA1 = A1;

            CCBounceA03 A2 = ScriptableObject.CreateInstance<CCBounceA03>();

            A2.singleTime = characterSingleTimeB;
            A2.easingType = easingTypeB;
            A2.scale = new Vector2(0, 1);
            A2.anchorType = AnchorType.Bottom;
            A2.bounces = 1;
            A2.bounciness = 0.75f;

            presetA2 = A2;

            CCBounceA03 A3 = ScriptableObject.CreateInstance<CCBounceA03>();

            A3.singleTime = characterSingleTimeC;
            A3.easingType = easingTypeC;
            A3.scale = new Vector2(1, 0);
            A3.anchorType = AnchorType.Right;
            A3.bounces = 1;
            A3.bounciness = 0.75f;

            presetA3 = A3;

            CCBounceA03 A4 = ScriptableObject.CreateInstance<CCBounceA03>();

            A4.singleTime = characterSingleTimeD;
            A4.easingType = easingTypeD;
            A4.scale = new Vector2(1, 0);
            A4.anchorType = AnchorType.Left;
            A4.bounces = 1;
            A4.bounciness = 0.75f;

            presetA4 = A4;

            CWBounceA03 B1 = ScriptableObject.CreateInstance<CWBounceA03>();

            B1.singleTime = wordSingleTimeA;
            B1.easingType = easingTypeA;
            B1.scale = new Vector2(1, 0);
            B1.anchorType = AnchorType.Top;
            B1.bounces = 2;
            B1.bounciness = 0.75f;

            presetB1 = B1;

            CWBounceA03 B2 = ScriptableObject.CreateInstance<CWBounceA03>();

            B2.singleTime = wordSingleTimeB;
            B2.easingType = easingTypeB;
            B2.scale = new Vector2(1, 0);
            B2.anchorType = AnchorType.Bottom;
            B2.bounces = 2;
            B2.bounciness = 0.75f;

            presetB2 = B2;

            CWBounceA03 B3 = ScriptableObject.CreateInstance<CWBounceA03>();

            B3.singleTime = wordSingleTimeC;
            B3.easingType = easingTypeC;
            B3.scale = new Vector2(0, 1);
            B3.anchorType = AnchorType.Right;
            B3.bounces = 2;
            B3.bounciness = 0.75f;

            presetB3 = B3;

            CWBounceA03 B4 = ScriptableObject.CreateInstance<CWBounceA03>();

            B4.singleTime = wordSingleTimeD;
            B4.easingType = easingTypeD;
            B4.scale = new Vector2(0, 1);
            B4.anchorType = AnchorType.Left;
            B4.bounces = 2;
            B4.bounciness = 0.75f;

            presetB4 = B4;

            CLBounceA03 C1 = ScriptableObject.CreateInstance<CLBounceA03>();

            C1.singleTime = lineSingleTimeA;
            C1.easingType = easingTypeA;
            C1.scale = new Vector2(0, 0);
            C1.anchorType = AnchorType.Center;
            C1.bounces = 1;
            C1.bounciness = 0.75f;

            presetC1 = C1;

            CLBounceA03 C2 = ScriptableObject.CreateInstance<CLBounceA03>();

            C2.singleTime = lineSingleTimeB;
            C2.easingType = easingTypeB;
            C2.scale = new Vector2(0, 0);
            C2.anchorType = AnchorType.Center;
            C2.bounces = 1;
            C2.bounciness = 0.75f;

            presetC2 = C2;

            CLBounceA03 C3 = ScriptableObject.CreateInstance<CLBounceA03>();

            C3.singleTime = lineSingleTimeC;
            C3.easingType = easingTypeC;
            C3.scale = new Vector2(0, 0);
            C3.anchorType = AnchorType.Center;
            C3.bounces = 2;
            C3.bounciness = 0.5f;

            presetC3 = C3;

            CLBounceA03 C4 = ScriptableObject.CreateInstance<CLBounceA03>();

            C4.singleTime = lineSingleTimeD;
            C4.easingType = easingTypeD;
            C4.scale = new Vector2(0, 0);
            C4.anchorType = AnchorType.Center;
            C4.bounces = 2;
            C4.bounciness = 0.5f;

            presetC4 = C4;

            CGBounceA03 D1 = ScriptableObject.CreateInstance<CGBounceA03>();

            D1.singleTime = groupSingleTimeA;
            D1.easingType = easingTypeA;
            D1.scale = new Vector2(0, 0);
            D1.anchorType = AnchorType.Center;
            D1.bounces = 2;
            D1.bounciness = 0.5f;

            presetD1 = D1;

            CGBounceA03 D2 = ScriptableObject.CreateInstance<CGBounceA03>();

            D2.singleTime = groupSingleTimeB;
            D2.easingType = easingTypeB;
            D2.scale = new Vector2(0, 0);
            D2.anchorType = AnchorType.Center;
            D2.bounces = 2;
            D2.bounciness = 0.5f;

            presetD2 = D2;

            CGBounceA03 D3 = ScriptableObject.CreateInstance<CGBounceA03>();

            D3.singleTime = groupSingleTimeC;
            D3.easingType = easingTypeC;
            D3.scale = new Vector2(0, 0);
            D3.anchorType = AnchorType.Center;
            D3.bounces = 1;
            D3.bounciness = 0.75f;

            presetD3 = D3;

            CGBounceA03 D4 = ScriptableObject.CreateInstance<CGBounceA03>();

            D4.singleTime = groupSingleTimeD;
            D4.easingType = easingTypeD;
            D4.scale = new Vector2(0, 0);
            D4.anchorType = AnchorType.Center;
            D4.bounces = 1;
            D4.bounciness = 0.75f;

            presetD4 = D4;

            AddAnimatextComponents();
        }
    }
}
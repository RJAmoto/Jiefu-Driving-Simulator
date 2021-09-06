using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class TBasicA04Script : BaseUnitScript
    {
        private void Start()
        {
            TCBasicA04 A1 = ScriptableObject.CreateInstance<TCBasicA04>();

            A1.singleTime = characterSingleTimeA;
            A1.easingType = easingTypeA;
            A1.fadeRange.end = fadeRangeEndValueA;
            A1.skew = new Vector2(0, 30);
            A1.anchorType = AnchorType.Top;

            presetA1 = A1;

            TCBasicA04 A2 = ScriptableObject.CreateInstance<TCBasicA04>();

            A2.singleTime = characterSingleTimeB;
            A2.easingType = easingTypeB;
            A2.fadeRange.end = fadeRangeEndValueB;
            A2.skew = new Vector2(0, 30);
            A2.anchorType = AnchorType.Bottom;

            presetA2 = A2;

            TCBasicA04 A3 = ScriptableObject.CreateInstance<TCBasicA04>();

            A3.singleTime = characterSingleTimeC;
            A3.easingType = easingTypeC;
            A3.fadeRange.end = fadeRangeEndValueC;
            A3.skew = new Vector2(30, 0);
            A3.anchorType = AnchorType.Right;

            presetA3 = A3;

            TCBasicA04 A4 = ScriptableObject.CreateInstance<TCBasicA04>();

            A4.singleTime = characterSingleTimeD;
            A4.easingType = easingTypeD;
            A4.fadeRange.end = fadeRangeEndValueD;
            A4.skew = new Vector2(30, 0);
            A4.anchorType = AnchorType.Left;

            presetA4 = A4;

            TWBasicA04 B1 = ScriptableObject.CreateInstance<TWBasicA04>();

            B1.singleTime = wordSingleTimeA;
            B1.easingType = easingTypeA;
            B1.fadeRange.end = fadeRangeEndValueA;
            B1.skew = new Vector2(15, 0);
            B1.anchorType = AnchorType.Top;

            presetB1 = B1;

            TWBasicA04 B2 = ScriptableObject.CreateInstance<TWBasicA04>();

            B2.singleTime = wordSingleTimeB;
            B2.easingType = easingTypeB;
            B2.fadeRange.end = fadeRangeEndValueB;
            B2.skew = new Vector2(15, 0);
            B2.anchorType = AnchorType.Bottom;

            presetB2 = B2;

            TWBasicA04 B3 = ScriptableObject.CreateInstance<TWBasicA04>();

            B3.singleTime = wordSingleTimeC;
            B3.easingType = easingTypeC;
            B3.fadeRange.end = fadeRangeEndValueC;
            B3.skew = new Vector2(0, 30);
            B3.anchorType = AnchorType.Right;

            presetB3 = B3;

            TWBasicA04 B4 = ScriptableObject.CreateInstance<TWBasicA04>();

            B4.singleTime = wordSingleTimeD;
            B4.easingType = easingTypeD;
            B4.fadeRange.end = fadeRangeEndValueD;
            B4.skew = new Vector2(0, 30);
            B4.anchorType = AnchorType.Left;

            presetB4 = B4;

            TLBasicA04 C1 = ScriptableObject.CreateInstance<TLBasicA04>();

            C1.singleTime = lineSingleTimeA;
            C1.easingType = easingTypeA;
            C1.fadeRange.end = fadeRangeEndValueA;
            C1.skew = new Vector2(0, 30);
            C1.anchorType = AnchorType.Center;

            presetC1 = C1;

            TLBasicA04 C2 = ScriptableObject.CreateInstance<TLBasicA04>();

            C2.singleTime = lineSingleTimeB;
            C2.easingType = easingTypeB;
            C2.fadeRange.end = fadeRangeEndValueB;
            C2.skew = new Vector2(0, 30);
            C2.anchorType = AnchorType.Center;

            presetC2 = C2;

            TLBasicA04 C3 = ScriptableObject.CreateInstance<TLBasicA04>();

            C3.singleTime = lineSingleTimeC;
            C3.easingType = easingTypeC;
            C3.fadeRange.end = fadeRangeEndValueC;
            C3.skew = new Vector2(15, 0);
            C3.anchorType = AnchorType.Center;

            presetC3 = C3;

            TLBasicA04 C4 = ScriptableObject.CreateInstance<TLBasicA04>();

            C4.singleTime = lineSingleTimeD;
            C4.easingType = easingTypeD;
            C4.fadeRange.end = fadeRangeEndValueD;
            C4.skew = new Vector2(15, 0);
            C4.anchorType = AnchorType.Center;

            presetC4 = C4;

            TGBasicA04 D1 = ScriptableObject.CreateInstance<TGBasicA04>();

            D1.singleTime = groupSingleTimeA;
            D1.easingType = easingTypeA;
            D1.fadeRange.end = fadeRangeEndValueA;
            D1.skew = new Vector2(30, 0);
            D1.anchorType = AnchorType.Center;

            presetD1 = D1;

            TGBasicA04 D2 = ScriptableObject.CreateInstance<TGBasicA04>();

            D2.singleTime = groupSingleTimeB;
            D2.easingType = easingTypeB;
            D2.fadeRange.end = fadeRangeEndValueB;
            D2.skew = new Vector2(30, 0);
            D2.anchorType = AnchorType.Center;

            presetD2 = D2;

            TGBasicA04 D3 = ScriptableObject.CreateInstance<TGBasicA04>();

            D3.singleTime = groupSingleTimeC;
            D3.easingType = easingTypeC;
            D3.fadeRange.end = fadeRangeEndValueC;
            D3.skew = new Vector2(0, 30);
            D3.anchorType = AnchorType.Center;

            presetD3 = D3;

            TGBasicA04 D4 = ScriptableObject.CreateInstance<TGBasicA04>();

            D4.singleTime = groupSingleTimeD;
            D4.easingType = easingTypeD;
            D4.fadeRange.end = fadeRangeEndValueD;
            D4.skew = new Vector2(0, 30);
            D4.anchorType = AnchorType.Center;

            presetD4 = D4;

            AddAnimatextComponents();
        }
    }
}
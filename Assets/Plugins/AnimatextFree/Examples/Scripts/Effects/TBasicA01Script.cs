using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class TBasicA01Script : BaseUnitScript
    {
        private void Start()
        {
            TCBasicA01 A1 = ScriptableObject.CreateInstance<TCBasicA01>();

            A1.singleTime = characterSingleTimeA;
            A1.easingType = easingTypeA;
            A1.fadeRange.end = fadeRangeEndValueA;
            A1.position = new Vector2(0, 45);

            presetA1 = A1;

            TCBasicA01 A2 = ScriptableObject.CreateInstance<TCBasicA01>();

            A2.singleTime = characterSingleTimeB;
            A2.easingType = easingTypeB;
            A2.fadeRange.end = fadeRangeEndValueB;
            A2.position = new Vector2(0, 45);

            presetA2 = A2;

            TCBasicA01 A3 = ScriptableObject.CreateInstance<TCBasicA01>();

            A3.singleTime = characterSingleTimeC;
            A3.easingType = easingTypeC;
            A3.fadeRange.end = fadeRangeEndValueC;
            A3.position = new Vector2(-45, 0);

            presetA3 = A3;

            TCBasicA01 A4 = ScriptableObject.CreateInstance<TCBasicA01>();

            A4.singleTime = characterSingleTimeD;
            A4.easingType = easingTypeD;
            A4.fadeRange.end = fadeRangeEndValueD;
            A4.position = new Vector2(-45, 0);

            presetA4 = A4;

            TWBasicA01 B1 = ScriptableObject.CreateInstance<TWBasicA01>();

            B1.singleTime = wordSingleTimeA;
            B1.easingType = easingTypeA;
            B1.fadeRange.end = fadeRangeEndValueA;
            B1.position = new Vector2(30, 45);

            presetB1 = B1;

            TWBasicA01 B2 = ScriptableObject.CreateInstance<TWBasicA01>();

            B2.singleTime = wordSingleTimeB;
            B2.easingType = easingTypeB;
            B2.fadeRange.end = fadeRangeEndValueB;
            B2.position = new Vector2(30, 45);

            presetB2 = B2;

            TWBasicA01 B3 = ScriptableObject.CreateInstance<TWBasicA01>();

            B3.singleTime = wordSingleTimeC;
            B3.easingType = easingTypeC;
            B3.fadeRange.end = fadeRangeEndValueC;
            B3.position = new Vector2(-30, 45);

            presetB3 = B3;

            TWBasicA01 B4 = ScriptableObject.CreateInstance<TWBasicA01>();

            B4.singleTime = wordSingleTimeD;
            B4.easingType = easingTypeD;
            B4.fadeRange.end = fadeRangeEndValueD;
            B4.position = new Vector2(-30, 45);

            presetB4 = B4;

            TLBasicA01 C1 = ScriptableObject.CreateInstance<TLBasicA01>();

            C1.singleTime = lineSingleTimeA;
            C1.easingType = easingTypeA;
            C1.fadeRange.end = fadeRangeEndValueA;
            C1.position = new Vector2(-30, 45);

            presetC1 = C1;

            TLBasicA01 C2 = ScriptableObject.CreateInstance<TLBasicA01>();

            C2.singleTime = lineSingleTimeB;
            C2.easingType = easingTypeB;
            C2.fadeRange.end = fadeRangeEndValueB;
            C2.position = new Vector2(-30, 45);

            presetC2 = C2;

            TLBasicA01 C3 = ScriptableObject.CreateInstance<TLBasicA01>();

            C3.singleTime = lineSingleTimeC;
            C3.easingType = easingTypeC;
            C3.fadeRange.end = fadeRangeEndValueC;
            C3.position = new Vector2(-30, -45);

            presetC3 = C3;

            TLBasicA01 C4 = ScriptableObject.CreateInstance<TLBasicA01>();

            C4.singleTime = lineSingleTimeD;
            C4.easingType = easingTypeD;
            C4.fadeRange.end = fadeRangeEndValueD;
            C4.position = new Vector2(-30, -45);

            presetC4 = C4;

            TGBasicA01 D1 = ScriptableObject.CreateInstance<TGBasicA01>();

            D1.singleTime = groupSingleTimeA;
            D1.easingType = easingTypeA;
            D1.fadeRange.end = fadeRangeEndValueA;
            D1.position = new Vector2(0, 45);

            presetD1 = D1;

            TGBasicA01 D2 = ScriptableObject.CreateInstance<TGBasicA01>();

            D2.singleTime = groupSingleTimeB;
            D2.easingType = easingTypeB;
            D2.fadeRange.end = fadeRangeEndValueB;
            D2.position = new Vector2(0, 45);

            presetD2 = D2;

            TGBasicA01 D3 = ScriptableObject.CreateInstance<TGBasicA01>();

            D3.singleTime = groupSingleTimeC;
            D3.easingType = easingTypeC;
            D3.fadeRange.end = fadeRangeEndValueC;
            D3.position = new Vector2(45, 0);

            presetD3 = D3;

            TGBasicA01 D4 = ScriptableObject.CreateInstance<TGBasicA01>();

            D4.singleTime = groupSingleTimeD;
            D4.easingType = easingTypeD;
            D4.fadeRange.end = fadeRangeEndValueD;
            D4.position = new Vector2(45, 0);

            presetD4 = D4;

            AddAnimatextComponents();
        }
    }
}
using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class TBasicA05Script : BaseUnitScript
    {
        private void Start()
        {
            TCBasicA05 A1 = ScriptableObject.CreateInstance<TCBasicA05>();

            A1.singleTime = characterSingleTimeA;
            A1.easingType = easingTypeA;

            presetA1 = A1;

            TCBasicA05 A2 = ScriptableObject.CreateInstance<TCBasicA05>();

            A2.singleTime = characterSingleTimeB;
            A2.easingType = easingTypeB;

            presetA2 = A2;

            TCBasicA05 A3 = ScriptableObject.CreateInstance<TCBasicA05>();

            A3.singleTime = characterSingleTimeC;
            A3.easingType = easingTypeC;

            presetA3 = A3;

            TCBasicA05 A4 = ScriptableObject.CreateInstance<TCBasicA05>();

            A4.singleTime = characterSingleTimeD;
            A4.easingType = easingTypeD;

            presetA4 = A4;

            TWBasicA05 B1 = ScriptableObject.CreateInstance<TWBasicA05>();

            B1.singleTime = wordSingleTimeA;
            B1.easingType = easingTypeA;

            presetB1 = B1;

            TWBasicA05 B2 = ScriptableObject.CreateInstance<TWBasicA05>();

            B2.singleTime = wordSingleTimeB;
            B2.easingType = easingTypeB;

            presetB2 = B2;

            TWBasicA05 B3 = ScriptableObject.CreateInstance<TWBasicA05>();

            B3.singleTime = wordSingleTimeC;
            B3.easingType = easingTypeC;

            presetB3 = B3;

            TWBasicA05 B4 = ScriptableObject.CreateInstance<TWBasicA05>();

            B4.singleTime = wordSingleTimeD;
            B4.easingType = easingTypeD;

            presetB4 = B4;

            TLBasicA05 C1 = ScriptableObject.CreateInstance<TLBasicA05>();

            C1.singleTime = lineSingleTimeA;
            C1.easingType = easingTypeA;

            presetC1 = C1;

            TLBasicA05 C2 = ScriptableObject.CreateInstance<TLBasicA05>();

            C2.singleTime = lineSingleTimeB;
            C2.easingType = easingTypeB;

            presetC2 = C2;

            TLBasicA05 C3 = ScriptableObject.CreateInstance<TLBasicA05>();

            C3.singleTime = lineSingleTimeC;
            C3.easingType = easingTypeC;

            presetC3 = C3;

            TLBasicA05 C4 = ScriptableObject.CreateInstance<TLBasicA05>();

            C4.singleTime = lineSingleTimeD;
            C4.easingType = easingTypeD;

            presetC4 = C4;

            TGBasicA05 D1 = ScriptableObject.CreateInstance<TGBasicA05>();

            D1.singleTime = groupSingleTimeA;
            D1.easingType = easingTypeA;

            presetD1 = D1;

            TGBasicA05 D2 = ScriptableObject.CreateInstance<TGBasicA05>();

            D2.singleTime = groupSingleTimeB;
            D2.easingType = easingTypeB;

            presetD2 = D2;

            TGBasicA05 D3 = ScriptableObject.CreateInstance<TGBasicA05>();

            D3.singleTime = groupSingleTimeC;
            D3.easingType = easingTypeC;

            presetD3 = D3;

            TGBasicA05 D4 = ScriptableObject.CreateInstance<TGBasicA05>();

            D4.singleTime = groupSingleTimeD;
            D4.easingType = easingTypeD;

            presetD4 = D4;

            AddAnimatextComponents();
        }
    }
}
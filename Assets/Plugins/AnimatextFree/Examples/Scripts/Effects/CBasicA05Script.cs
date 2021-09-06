using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class CBasicA05Script : BaseUnitScript
    {
        private void Start()
        {
            CCBasicA05 A1 = ScriptableObject.CreateInstance<CCBasicA05>();

            A1.singleTime = characterSingleTimeA;
            A1.easingType = easingTypeA;
            A1.continuousEasing = false;
            A1.opacity = 0.5f;

            presetA1 = A1;

            CCBasicA05 A2 = ScriptableObject.CreateInstance<CCBasicA05>();

            A2.singleTime = characterSingleTimeB;
            A2.easingType = easingTypeB;
            A2.continuousEasing = false;
            A2.opacity = 0.5f;

            presetA2 = A2;

            CCBasicA05 A3 = ScriptableObject.CreateInstance<CCBasicA05>();

            A3.singleTime = characterSingleTimeC;
            A3.easingType = easingTypeC;
            A3.continuousEasing = true;
            A3.opacity = 0;

            presetA3 = A3;

            CCBasicA05 A4 = ScriptableObject.CreateInstance<CCBasicA05>();

            A4.singleTime = characterSingleTimeD;
            A4.easingType = easingTypeD;
            A4.continuousEasing = true;
            A4.opacity = 0;

            presetA4 = A4;

            CWBasicA05 B1 = ScriptableObject.CreateInstance<CWBasicA05>();

            B1.singleTime = wordSingleTimeA;
            B1.easingType = easingTypeA;
            B1.continuousEasing = true;
            B1.opacity = 0.5f;

            presetB1 = B1;

            CWBasicA05 B2 = ScriptableObject.CreateInstance<CWBasicA05>();

            B2.singleTime = wordSingleTimeB;
            B2.easingType = easingTypeB;
            B2.continuousEasing = true;
            B2.opacity = 0.5f;

            presetB2 = B2;

            CWBasicA05 B3 = ScriptableObject.CreateInstance<CWBasicA05>();

            B3.singleTime = wordSingleTimeC;
            B3.easingType = easingTypeC;
            B3.continuousEasing = false;
            B3.opacity = 0;

            presetB3 = B3;

            CWBasicA05 B4 = ScriptableObject.CreateInstance<CWBasicA05>();

            B4.singleTime = wordSingleTimeD;
            B4.easingType = easingTypeD;
            B4.continuousEasing = false;
            B4.opacity = 0;

            presetB4 = B4;

            CLBasicA05 C1 = ScriptableObject.CreateInstance<CLBasicA05>();

            C1.singleTime = lineSingleTimeA;
            C1.easingType = easingTypeA;
            C1.continuousEasing = false;
            C1.opacity = 0.5f;

            presetC1 = C1;

            CLBasicA05 C2 = ScriptableObject.CreateInstance<CLBasicA05>();

            C2.singleTime = lineSingleTimeB;
            C2.easingType = easingTypeB;
            C2.continuousEasing = false;
            C2.opacity = 0.5f;

            presetC2 = C2;

            CLBasicA05 C3 = ScriptableObject.CreateInstance<CLBasicA05>();

            C3.singleTime = lineSingleTimeC;
            C3.easingType = easingTypeC;
            C3.continuousEasing = true;
            C3.opacity = 0;

            presetC3 = C3;

            CLBasicA05 C4 = ScriptableObject.CreateInstance<CLBasicA05>();

            C4.singleTime = lineSingleTimeD;
            C4.easingType = easingTypeD;
            C4.continuousEasing = true;
            C4.opacity = 0;

            presetC4 = C4;

            CGBasicA05 D1 = ScriptableObject.CreateInstance<CGBasicA05>();

            D1.singleTime = groupSingleTimeA;
            D1.easingType = easingTypeA;
            D1.continuousEasing = true;
            D1.opacity = 0.5f;

            presetD1 = D1;

            CGBasicA05 D2 = ScriptableObject.CreateInstance<CGBasicA05>();

            D2.singleTime = groupSingleTimeB;
            D2.easingType = easingTypeB;
            D2.continuousEasing = true;
            D2.opacity = 0.5f;

            presetD2 = D2;

            CGBasicA05 D3 = ScriptableObject.CreateInstance<CGBasicA05>();

            D3.singleTime = groupSingleTimeC;
            D3.easingType = easingTypeC;
            D3.continuousEasing = false;
            D3.opacity = 0;

            presetD3 = D3;

            CGBasicA05 D4 = ScriptableObject.CreateInstance<CGBasicA05>();

            D4.singleTime = groupSingleTimeD;
            D4.easingType = easingTypeD;
            D4.continuousEasing = false;
            D4.opacity = 0;

            presetD4 = D4;

            AddAnimatextComponents();
        }
    }
}
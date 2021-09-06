using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class CBasicA01Script : BaseUnitScript
    {
        private void Start()
        {
            CCBasicA01 A1 = ScriptableObject.CreateInstance<CCBasicA01>();

            A1.singleTime = characterSingleTimeA;
            A1.easingType = easingTypeA;
            A1.continuousEasing = false;
            A1.position = new Vector2(0, 24);

            presetA1 = A1;

            CCBasicA01 A2 = ScriptableObject.CreateInstance<CCBasicA01>();

            A2.singleTime = characterSingleTimeB;
            A2.easingType = easingTypeB;
            A2.continuousEasing = false;
            A2.position = new Vector2(0, 24);

            presetA2 = A2;

            CCBasicA01 A3 = ScriptableObject.CreateInstance<CCBasicA01>();

            A3.singleTime = characterSingleTimeC;
            A3.easingType = easingTypeC;
            A3.continuousEasing = true;
            A3.position = new Vector2(0, -24);

            presetA3 = A3;

            CCBasicA01 A4 = ScriptableObject.CreateInstance<CCBasicA01>();

            A4.singleTime = characterSingleTimeD;
            A4.easingType = easingTypeD;
            A4.continuousEasing = true;
            A4.position = new Vector2(0, -24);

            presetA4 = A4;

            CWBasicA01 B1 = ScriptableObject.CreateInstance<CWBasicA01>();

            B1.singleTime = wordSingleTimeA;
            B1.easingType = easingTypeA;
            B1.continuousEasing = true;
            B1.position = new Vector2(15, 24);

            presetB1 = B1;

            CWBasicA01 B2 = ScriptableObject.CreateInstance<CWBasicA01>();

            B2.singleTime = wordSingleTimeB;
            B2.easingType = easingTypeB;
            B2.continuousEasing = true;
            B2.position = new Vector2(15, 24);

            presetB2 = B2;

            CWBasicA01 B3 = ScriptableObject.CreateInstance<CWBasicA01>();

            B3.singleTime = wordSingleTimeC;
            B3.easingType = easingTypeC;
            B3.continuousEasing = false;
            B3.position = new Vector2(-15, 24);

            presetB3 = B3;

            CWBasicA01 B4 = ScriptableObject.CreateInstance<CWBasicA01>();

            B4.singleTime = wordSingleTimeD;
            B4.easingType = easingTypeD;
            B4.continuousEasing = false;
            B4.position = new Vector2(-15, 24);

            presetB4 = B4;

            CLBasicA01 C1 = ScriptableObject.CreateInstance<CLBasicA01>();

            C1.singleTime = lineSingleTimeA;
            C1.easingType = easingTypeA;
            C1.continuousEasing = false;
            C1.position = new Vector2(-15, 24);

            presetC1 = C1;

            CLBasicA01 C2 = ScriptableObject.CreateInstance<CLBasicA01>();

            C2.singleTime = lineSingleTimeB;
            C2.easingType = easingTypeB;
            C2.continuousEasing = false;
            C2.position = new Vector2(-15, 24);

            presetC2 = C2;

            CLBasicA01 C3 = ScriptableObject.CreateInstance<CLBasicA01>();

            C3.singleTime = lineSingleTimeC;
            C3.easingType = easingTypeC;
            C3.continuousEasing = true;
            C3.position = new Vector2(-15, -24);

            presetC3 = C3;

            CLBasicA01 C4 = ScriptableObject.CreateInstance<CLBasicA01>();

            C4.singleTime = lineSingleTimeD;
            C4.easingType = easingTypeD;
            C4.continuousEasing = true;
            C4.position = new Vector2(15, 24);

            presetC4 = C4;

            CGBasicA01 D1 = ScriptableObject.CreateInstance<CGBasicA01>();

            D1.singleTime = groupSingleTimeA;
            D1.easingType = easingTypeA;
            D1.continuousEasing = true;
            D1.position = new Vector2(0, -24);

            presetD1 = D1;

            CGBasicA01 D2 = ScriptableObject.CreateInstance<CGBasicA01>();

            D2.singleTime = groupSingleTimeB;
            D2.easingType = easingTypeB;
            D2.continuousEasing = true;
            D2.position = new Vector2(0, -24);

            presetD2 = D2;

            CGBasicA01 D3 = ScriptableObject.CreateInstance<CGBasicA01>();

            D3.singleTime = groupSingleTimeC;
            D3.easingType = easingTypeC;
            D3.continuousEasing = false;
            D3.position = new Vector2(0, 24);

            presetD3 = D3;

            CGBasicA01 D4 = ScriptableObject.CreateInstance<CGBasicA01>();

            D4.singleTime = groupSingleTimeD;
            D4.easingType = easingTypeD;
            D4.continuousEasing = false;
            D4.position = new Vector2(0, 24);

            presetD4 = D4;

            AddAnimatextComponents();
        }
    }
}
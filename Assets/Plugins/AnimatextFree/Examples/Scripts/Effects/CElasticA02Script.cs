using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class CElasticA02Script : BaseUnitScript
    {
        private void Start()
        {
            CCElasticA02 A1 = ScriptableObject.CreateInstance<CCElasticA02>();

            A1.singleTime = characterSingleTimeA;
            A1.easingType = easingTypeA;
            A1.rotation = 90f;
            A1.anchorType = AnchorType.Top;
            A1.anchorOffset = Vector2.zero;
            A1.oscillations = 1;
            A1.stiffness = 2.5f;

            presetA1 = A1;

            CCElasticA02 A2 = ScriptableObject.CreateInstance<CCElasticA02>();

            A2.singleTime = characterSingleTimeB;
            A2.easingType = easingTypeB;
            A2.rotation = 90f;
            A2.anchorType = AnchorType.Bottom;
            A2.anchorOffset = Vector2.zero;
            A2.oscillations = 1;
            A2.stiffness = 2.5f;

            presetA2 = A2;

            CCElasticA02 A3 = ScriptableObject.CreateInstance<CCElasticA02>();

            A3.singleTime = characterSingleTimeC;
            A3.easingType = easingTypeC;
            A3.rotation = 90f;
            A3.anchorType = AnchorType.Right;
            A3.anchorOffset = Vector2.zero;
            A3.oscillations = 1;
            A3.stiffness = 2.5f;

            presetA3 = A3;

            CCElasticA02 A4 = ScriptableObject.CreateInstance<CCElasticA02>();

            A4.singleTime = characterSingleTimeD;
            A4.easingType = easingTypeD;
            A4.rotation = 90f;
            A4.anchorType = AnchorType.Left;
            A4.anchorOffset = Vector2.zero;
            A4.oscillations = 1;
            A4.stiffness = 2.5f;

            presetA4 = A4;

            CWElasticA02 B1 = ScriptableObject.CreateInstance<CWElasticA02>();

            B1.singleTime = wordSingleTimeA;
            B1.easingType = easingTypeA;
            B1.rotation = 45f;
            B1.anchorType = AnchorType.Top;
            B1.anchorOffset = Vector2.zero;
            B1.oscillations = 3;
            B1.stiffness = 5f;

            presetB1 = B1;

            CWElasticA02 B2 = ScriptableObject.CreateInstance<CWElasticA02>();

            B2.singleTime = wordSingleTimeB;
            B2.easingType = easingTypeB;
            B2.rotation = 45f;
            B2.anchorType = AnchorType.Bottom;
            B2.anchorOffset = Vector2.zero;
            B2.oscillations = 3;
            B2.stiffness = 5f;

            presetB2 = B2;

            CWElasticA02 B3 = ScriptableObject.CreateInstance<CWElasticA02>();

            B3.singleTime = wordSingleTimeC;
            B3.easingType = easingTypeC;
            B3.rotation = 15f;
            B3.anchorType = AnchorType.Right;
            B3.anchorOffset = Vector2.zero;
            B3.oscillations = 3;
            B3.stiffness = 5f;

            presetB3 = B3;

            CWElasticA02 B4 = ScriptableObject.CreateInstance<CWElasticA02>();

            B4.singleTime = wordSingleTimeD;
            B4.easingType = easingTypeD;
            B4.rotation = 15f;
            B4.anchorType = AnchorType.Left;
            B4.anchorOffset = Vector2.zero;
            B4.oscillations = 3;
            B4.stiffness = 5f;

            presetB4 = B4;

            CLElasticA02 C1 = ScriptableObject.CreateInstance<CLElasticA02>();

            C1.singleTime = lineSingleTimeA;
            C1.easingType = easingTypeA;
            C1.rotation = 45f;
            C1.anchorType = AnchorType.Center;
            C1.anchorOffset = Vector2.zero;
            C1.oscillations = 2;
            C1.stiffness = 6f;

            presetC1 = C1;

            CLElasticA02 C2 = ScriptableObject.CreateInstance<CLElasticA02>();

            C2.singleTime = lineSingleTimeB;
            C2.easingType = easingTypeB;
            C2.rotation = 45f;
            C2.anchorType = AnchorType.Center;
            C2.anchorOffset = Vector2.zero;
            C2.oscillations = 2;
            C2.stiffness = 6f;

            presetC2 = C2;

            CLElasticA02 C3 = ScriptableObject.CreateInstance<CLElasticA02>();

            C3.singleTime = lineSingleTimeC;
            C3.easingType = easingTypeC;
            C3.rotation = 15f;
            C3.anchorType = AnchorType.Center;
            C3.anchorOffset = Vector2.zero;
            C3.oscillations = 2;
            C3.stiffness = 6f;

            presetC3 = C3;

            CLElasticA02 C4 = ScriptableObject.CreateInstance<CLElasticA02>();

            C4.singleTime = lineSingleTimeD;
            C4.easingType = easingTypeD;
            C4.rotation = 15f;
            C4.anchorType = AnchorType.Center;
            C4.anchorOffset = Vector2.zero;
            C4.oscillations = 2;
            C4.stiffness = 6f;

            presetC4 = C4;

            CGElasticA02 D1 = ScriptableObject.CreateInstance<CGElasticA02>();

            D1.singleTime = groupSingleTimeA;
            D1.easingType = easingTypeA;
            D1.rotation = 30f;
            D1.anchorType = AnchorType.Center;
            D1.anchorOffset = Vector2.zero;
            D1.oscillations = 1;
            D1.stiffness = 2.5f;

            presetD1 = D1;

            CGElasticA02 D2 = ScriptableObject.CreateInstance<CGElasticA02>();

            D2.singleTime = groupSingleTimeB;
            D2.easingType = easingTypeB;
            D2.rotation = 30f;
            D2.anchorType = AnchorType.Center;
            D2.anchorOffset = Vector2.zero;
            D2.oscillations = 1;
            D2.stiffness = 2.5f;

            presetD2 = D2;

            CGElasticA02 D3 = ScriptableObject.CreateInstance<CGElasticA02>();

            D3.singleTime = groupSingleTimeC;
            D3.easingType = easingTypeC;
            D3.rotation = 45f;
            D3.anchorType = AnchorType.Center;
            D3.anchorOffset = Vector2.zero;
            D3.oscillations = 1;
            D3.stiffness = 2.5f;

            presetD3 = D3;

            CGElasticA02 D4 = ScriptableObject.CreateInstance<CGElasticA02>();

            D4.singleTime = groupSingleTimeD;
            D4.easingType = easingTypeD;
            D4.rotation = 45f;
            D4.anchorType = AnchorType.Center;
            D4.anchorOffset = Vector2.zero;
            D4.oscillations = 1;
            D4.stiffness = 2.5f;

            presetD4 = D4;

            AddAnimatextComponents();
        }
    }
}
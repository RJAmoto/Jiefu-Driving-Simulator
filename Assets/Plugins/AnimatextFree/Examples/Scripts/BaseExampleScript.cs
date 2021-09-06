using UnityEngine;

namespace AnimatextFree.Examples
{
    public class BaseExampleScript : MonoBehaviour
    {
        protected static GeneralParamGroup generalParamGroup = new GeneralParamGroup() 
        { 
            autoPlay = true, 
            autoStart = true, 
            refreshMode = RefreshMode.Continue, 
            tag = "AT"
        };

        protected void AddAnimatextComponent(GameObject gameObject, Effect effect)
        {
            if (gameObject == null || effect == null) return;

            AnimatextFreeUGUI animatext = gameObject.AddComponent<AnimatextFreeUGUI>();

            animatext.effects.Add(effect);

            animatext.text = "<" + effect.tag + ">" + animatext.text;
        }

        protected void AddAnimatextComponent(GameObject gameObject, Effect effect, bool refreshText)
        {
            if (gameObject == null || effect == null) return;

            AnimatextFreeUGUI animatext = gameObject.AddComponent<AnimatextFreeUGUI>();

            animatext.effects.Add(effect);

            animatext.Refresh(refreshText);
        }

        protected void AddAnimatextComponent(GameObject gameObject, Effect effect, out AnimatextFreeUGUI animatext)
        {
            if (gameObject == null || effect == null)
            {
                animatext = null;

                return;
            }

            animatext = gameObject.AddComponent<AnimatextFreeUGUI>();

            animatext.effects.Add(effect);

            animatext.text = "<" + effect.tag + ">" + animatext.text;
        }


        protected void AddAnimatextComponent(GameObject gameObject, Effect effect, RetainedText retainedText)
        {
            if (gameObject == null || effect == null) return;

            AnimatextFreeUGUI animatext = gameObject.AddComponent<AnimatextFreeUGUI>();

            animatext.settings.retainedText = retainedText;
            animatext.effects.Add(effect);

            animatext.text = "<" + effect.tag + ">" + animatext.text;
        }

        protected void AddAnimatextComponent(GameObject gameObject, Effect effect, TagSymbols tagSymbols, MarkerSymbols markerSymbols)
        {
            if (gameObject == null || effect == null) return;

            AnimatextFreeUGUI animatext = gameObject.AddComponent<AnimatextFreeUGUI>();

            animatext.settings.tagSymbols = tagSymbols;
            animatext.settings.markerSymbols = markerSymbols;

            animatext.effects.Add(effect);

            char openingChar;
            char closingChar;

            switch (tagSymbols)
            {
                case TagSymbols.AngleBrackets:
                    openingChar = '<';
                    closingChar = '>';
                    break;

                case TagSymbols.RoundBrackets:
                    openingChar = '(';
                    closingChar = ')';
                    break;

                case TagSymbols.SquareBrackets:
                    openingChar = '[';
                    closingChar = ']';
                    break;

                case TagSymbols.CurlyBrackets:
                    openingChar = '{';
                    closingChar = '}';
                    break;

                default:
                    openingChar = '<';
                    closingChar = '>';
                    break;
            }

            char markerChar;

            switch (markerSymbols)
            {
                case MarkerSymbols.Slashes:
                    markerChar = '/';
                    break;

                case MarkerSymbols.Backslashes:
                    markerChar = '\\';
                    break;

                case MarkerSymbols.VerticalBars:
                    markerChar = '|';
                    break;

                default:
                    markerChar = '/';
                    break;
            }

            animatext.text = openingChar + effect.tag + closingChar + animatext.text + openingChar + markerChar + effect.tag + closingChar;
        }

        protected void AddAnimatextEffect(GameObject gameObject, Effect effect)
        {
            if (gameObject == null || effect == null) return;

            AnimatextFreeUGUI animatext = gameObject.GetComponent<AnimatextFreeUGUI>();

            if (animatext != null)
            {
                animatext.effects.Add(effect);
                animatext.text = "<" + effect.tag + ">" + animatext.text;
            }
        }
    }
}

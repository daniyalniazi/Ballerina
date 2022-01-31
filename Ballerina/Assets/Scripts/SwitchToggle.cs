using UnityEngine ;
using UnityEngine.UI ;

public class SwitchToggle : MonoBehaviour {
   [SerializeField] RectTransform uiHandleRectTransform ;
   Image backgroundImage, handleImage ;
   Toggle toggle ;
   Vector2 handlePosition ;
   void Awake ( ) {
      toggle = GetComponent <Toggle> ( ) ;
      handlePosition = uiHandleRectTransform.anchoredPosition ;
      backgroundImage = uiHandleRectTransform.parent.GetComponent <Image> ( ) ;
      handleImage = uiHandleRectTransform.GetComponent <Image> ( ) ;
      toggle.onValueChanged.AddListener (OnSwitch) ;

      if (toggle.isOn)
         OnSwitch (true) ;
   }

   void OnSwitch (bool on) {
      uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition ; // no anim
   }
   void OnDestroy ( ) {
      toggle.onValueChanged.RemoveListener (OnSwitch) ;
   }
}

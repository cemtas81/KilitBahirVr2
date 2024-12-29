using UnityEngine;
using UnityEngine.EventSystems;

using UnityEngine.XR.Interaction.Toolkit.UI;

public class HoverHaptic : MonoBehaviour, IPointerEnterHandler
{
    private XRUIInputModule InputModule => EventSystem.current.currentInputModule as XRUIInputModule;

    public void OnPointerEnter(PointerEventData eventData)
    {
        UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor interactor = InputModule.GetInteractor(eventData.pointerId) as UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor;
        interactor.xrController.SendHapticImpulse(0.25f, 0.25f);
    }
}
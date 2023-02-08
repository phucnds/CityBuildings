using System;
using UnityEngine;

namespace DPs
{
    public interface IInputManager
    {
        LayerMask MouseInputMask { get; set; }
        void AddListenerOnPointerDownEvent(Action<Vector3> listener);
        void AddListenerOnPointerUpEvent(Action listener);
        void AddListenerOnPointerChangeEvent(Action<Vector3> listener);
        void RemoveListenerOnPointerDownEvent(Action<Vector3> listener);
        void AddListenerOnPointerSecondDownEvent(Action<Vector3> listener);
        void AddListenerOnPointerSecondUpEvent(Action listener);
        void RemoveListenerOnPointerSecondChangeEvent(Action<Vector3> listener);
        void RemoveListenerOnPointerSecondUpEvent(Action listener);
        void RemoveListenerOnPointerUpEvent(Action listener);
        void RemoveListenerOnPointerChangeEvent(Action<Vector3> listener);
    }
}
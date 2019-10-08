using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Object", fileName = "ObjectList")]
    public sealed class ObjectList : ScriptableObjectList<object, ObjectEvent> { }
}

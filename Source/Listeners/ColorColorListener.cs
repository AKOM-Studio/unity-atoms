using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Color - Color")]
    public sealed class ColorColorListener : AtomListener<
        Color,
        Color,
        ColorColorAction,
        ColorColorEvent,
        ColorColorUnityEvent>
    { }
}

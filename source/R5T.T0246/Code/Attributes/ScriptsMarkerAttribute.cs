using System;

using R5T.T0143;


namespace R5T.T0246
{
    /// <summary>
    /// Attribute indicating an interface contains scripts (default implementation methods on an interface that have no inputs).
    /// The marker attribute is useful for surveying script interfaces and building a catalogue of scripts.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class ScriptsMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsScripts;

        /// <summary>
        /// Allows specifying that an interface is *not* a scripts interface.
        /// This is useful for marking interfaces that end up canonical script code file locations, but are not script interfaces.
        /// </summary>
        public bool IsScripts
        {
            get
            {
                return this.zIsScripts;
            }
        }


        public ScriptsMarkerAttribute(
            bool isScripts = true)
        {
            this.zIsScripts = isScripts;
        }
    }
}

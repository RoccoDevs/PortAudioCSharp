using System;

namespace PortAudioCSharp.Interop
{
    public class NativeTypeNameAttribute : Attribute
    {
        public NativeTypeNameAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
// <auto-generated/>

namespace Avalonia.Native.Interop
{
    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>AvnColor</unmanaged>
    /// <unmanaged-short>AvnColor</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct AvnColor
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Alpha</unmanaged>
        /// <unmanaged-short>Alpha</unmanaged-short>
        public System.Byte Alpha;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Red</unmanaged>
        /// <unmanaged-short>Red</unmanaged-short>
        public System.Byte Red;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Green</unmanaged>
        /// <unmanaged-short>Green</unmanaged-short>
        public System.Byte Green;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Blue</unmanaged>
        /// <unmanaged-short>Blue</unmanaged-short>
        public System.Byte Blue;
    }

    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>AvnFramebuffer</unmanaged>
    /// <unmanaged-short>AvnFramebuffer</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct AvnFramebuffer
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Data</unmanaged>
        /// <unmanaged-short>Data</unmanaged-short>
        public System.IntPtr Data;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Width</unmanaged>
        /// <unmanaged-short>Width</unmanaged-short>
        public System.Int32 Width;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Height</unmanaged>
        /// <unmanaged-short>Height</unmanaged-short>
        public System.Int32 Height;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Stride</unmanaged>
        /// <unmanaged-short>Stride</unmanaged-short>
        public System.Int32 Stride;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Dpi</unmanaged>
        /// <unmanaged-short>Dpi</unmanaged-short>
        public Avalonia.Native.Interop.AvnVector Dpi;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>PixelFormat</unmanaged>
        /// <unmanaged-short>PixelFormat</unmanaged-short>
        public Avalonia.Native.Interop.AvnPixelFormat PixelFormat;
    }

    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>AvnPixelSize</unmanaged>
    /// <unmanaged-short>AvnPixelSize</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct AvnPixelSize
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Width</unmanaged>
        /// <unmanaged-short>Width</unmanaged-short>
        public System.Int32 Width;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Height</unmanaged>
        /// <unmanaged-short>Height</unmanaged-short>
        public System.Int32 Height;
    }

    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>AvnPoint</unmanaged>
    /// <unmanaged-short>AvnPoint</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct AvnPoint
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>X</unmanaged>
        /// <unmanaged-short>X</unmanaged-short>
        public System.Double X;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Y</unmanaged>
        /// <unmanaged-short>Y</unmanaged-short>
        public System.Double Y;
    }

    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>AvnRect</unmanaged>
    /// <unmanaged-short>AvnRect</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct AvnRect
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>X</unmanaged>
        /// <unmanaged-short>X</unmanaged-short>
        public System.Double X;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Y</unmanaged>
        /// <unmanaged-short>Y</unmanaged-short>
        public System.Double Y;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Width</unmanaged>
        /// <unmanaged-short>Width</unmanaged-short>
        public System.Double Width;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Height</unmanaged>
        /// <unmanaged-short>Height</unmanaged-short>
        public System.Double Height;
    }

    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>AvnScreen</unmanaged>
    /// <unmanaged-short>AvnScreen</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct AvnScreen
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Bounds</unmanaged>
        /// <unmanaged-short>Bounds</unmanaged-short>
        public Avalonia.Native.Interop.AvnRect Bounds;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>WorkingArea</unmanaged>
        /// <unmanaged-short>WorkingArea</unmanaged-short>
        public Avalonia.Native.Interop.AvnRect WorkingArea;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>PixelDensity</unmanaged>
        /// <unmanaged-short>PixelDensity</unmanaged-short>
        public System.Single PixelDensity;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Primary</unmanaged>
        /// <unmanaged-short>Primary</unmanaged-short>
        public bool Primary
        {
            get => 0 != _Primary;
            set => _Primary = (System.Byte)(value ? 1 : 0);
        }

        internal System.Byte _Primary;
    }

    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>AvnSize</unmanaged>
    /// <unmanaged-short>AvnSize</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct AvnSize
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Width</unmanaged>
        /// <unmanaged-short>Width</unmanaged-short>
        public System.Double Width;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Height</unmanaged>
        /// <unmanaged-short>Height</unmanaged-short>
        public System.Double Height;
    }

    /// <summary>
    /// No documentation.
    /// </summary>
    /// <unmanaged>AvnVector</unmanaged>
    /// <unmanaged-short>AvnVector</unmanaged-short>
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public partial struct AvnVector
    {
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>X</unmanaged>
        /// <unmanaged-short>X</unmanaged-short>
        public System.Double X;
        /// <summary>
        /// No documentation.
        /// </summary>
        /// <unmanaged>Y</unmanaged>
        /// <unmanaged-short>Y</unmanaged-short>
        public System.Double Y;
    }
}
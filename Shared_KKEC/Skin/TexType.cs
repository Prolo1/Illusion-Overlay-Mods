using System;

namespace KoiSkinOverlayX
{
    /// <summary>
    /// Names are important, don't change! - used for filenames and extended data keys
    /// </summary>
    public enum TexType
    {
        Unknown = 0,
        BodyOver,
        FaceOver,
        BodyUnder,
        FaceUnder,
        [Obsolete]
        EyeUnder,
        [Obsolete]
        EyeOver,
        EyeUnderL,
        EyeOverL,
        EyeUnderR,
        EyeOverR
    }
}
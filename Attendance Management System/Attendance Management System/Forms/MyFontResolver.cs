using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Fonts;
using PdfSharp.Pdf.IO;

namespace Attendance_Management_System.Forms
{
   
public class MyFontResolver : IFontResolver
    {
        public byte[] GetFont(string faceName)
        {
            // Implement logic to load font data based on faceName
            // For example, you can load font data from a file or use embedded font resources

            // Here, we're returning null to indicate that the font data is not found
            return null;
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            // Implement logic to resolve typeface information

            // Here, we're returning null to indicate that the typeface information is not resolved
            return null;
        }
    }

}

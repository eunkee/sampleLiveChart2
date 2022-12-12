using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using SkiaSharp;

namespace sampleLiveChart2
{
    public class AlarmMarkerGeometry : SVGPathGeometry
    {
        // the static field is important to prevent the svg path is parsed multiple times 
        // Icon from Google Material Icons font.
        // https://fonts.google.com/icons?selected=Material%20Icons%20Outlined%3Amy_location%3A
        //public static SKPath svgPath = SKPath.ParseSvgPathData(
        //    "M12 8c-2.21 0-4 1.79-4 4s1.79 4 4 4 4-1.79 4-4-1.79-4-4-4zm8.94 3c-.46-4.17-3.77-7.48-7.94-7.94V1h-2v2.06C6.83 3.52 3.52 6.83 3.06 " +
        //    "11H1v2h2.06c.46 4.17 3.77 7.48 7.94 7.94V23h2v-2.06c4.17-.46 7.48-3.77 7.94-7.94H23v-2h-2.06zM12 19c-3.87 0-7-3.13-7-7s3.13-7 7-7 7 " +
        //    "3.13 7 7-3.13 7-7 7z");

        // M12 8c-2.21 0-4 1.79-4 4s1.79 4 4 4 4-1.79 4-4-1.79-4-4-4zm8.94 3c-.46-4.17-3.77-7.48-7.94-7.94V1h-2v2.06C6.83 3.52 3.52 6.83 3.06
        // 11H1v2h2.06c.46 4.17 3.77 7.48 7.94 7.94V23h2v-2.06c4.17-.46 7.48-3.77 7.94-7.94H23v-2h-2.06zM12 19c-3.87 0-7-3.13-7-7s3.13-7 7-7 7
        // 3.13 7 7-3.13 7-7 7z

        public static SKPath svgPath = SKPath.ParseSvgPathData(
            "M12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm1 15h-2v-2h2v2zm0-4h-2V7h2v6z");

        public AlarmMarkerGeometry()
            : base(svgPath)
        { }
    }
}

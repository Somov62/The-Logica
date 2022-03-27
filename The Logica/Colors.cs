using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace The_Logica
{
    public static class Colors
    {
        private static Dictionary<int, Color> _listColors = new()
        {
            { 0, Color.FromArgb(0xFF, 0xFF, 0x69, 0xB4) }, //pink
            { 1, Color.FromArgb(0xFF, 0x00, 0x7D, 0xFF) }, //blue
            { 2, Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF) }, //white
            { 3, Color.FromArgb(0xFF, 0xBA, 0x55, 0xD3) }, //purple
            { 4, Color.FromArgb(0xFF, 0xFF, 0xFF, 0x00) }, //yellow
            { 5, Color.FromArgb(0xFF, 0x34, 0xC9, 0x24) }, //green
            { 6, Color.FromArgb(0xFF, 0xF8, 0x17, 0x3E) }, //red
            { 7, Color.FromArgb(0xFF, 0xFF, 0x4F, 0x00) }, //orange
            { 8, Color.FromArgb(0xFF, 0x00, 0x00, 0x00) }, //black
        };

        public static Dictionary<int, Color> ListColors { get => _listColors; } 
        public static int TryGetKey(this Dictionary<int, Color> _listColors, Color value)
        {
            var item = _listColors.FirstOrDefault(p => p.Value == value);
            return item.Key;
        }
    }
}

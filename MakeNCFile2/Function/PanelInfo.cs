using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 패널의 크기나 dot의 크기등을 설정하는 클래스
/// </summary>
namespace MakeNCFile2.Function
{
    [Serializable]
    public class PanelInfo
    {
        public string pnFileName { get; set; }
        public double pnGridGap { get; set; }
        public Rectangle pnSize { get; set; }
                
        public Color pnGridLineColor { get; set; }
        public Color pnMarkColor { get; set; }
        public int pnMarkType { get; set; } // 0 : Circle, 1 : Rectangle

        public int[,] matrix;

        public void init()
        {
            pnGridGap = 1.0d;
            pnSize = new Rectangle()
            {
                X = 0,
                Y = 0,
                Width = 30,
                Height = 30
            };
            pnGridLineColor = Color.Black;
            pnMarkColor = Color.Blue;
            pnMarkType = 0;
        }
    }
}

using System.Windows.Forms;

namespace GenericListsPeformanceAndSpeedTest
{
    public partial class FrmHafizaGrafik : Form
    {
        public FrmHafizaGrafik(double a, double b, double c)
        {
            InitializeComponent();
            chart1.Series["Memory (MB)"].Points.AddXY("Array", a);
            chart1.Series["Memory (MB)"].Points.AddXY("ArrayList", b);
            chart1.Series["Memory (MB)"].Points.AddXY("List", c);
        }
    }
}

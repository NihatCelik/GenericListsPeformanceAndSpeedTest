using System.Windows.Forms;

namespace GenericListsPeformanceAndSpeedTest
{
    public partial class FrmGrafik : Form
    {
        public FrmGrafik(double arrayWrite, double arrayRead, double arrayListWrite, double arrayListRead, double listWrite, double listRead)
        {
            InitializeComponent(); 

            chart1.Series["Write"].Points.AddXY("Array", arrayWrite);
            chart1.Series["Read"].Points.AddXY("Array", arrayRead);

            chart1.Series["Write"].Points.AddXY("ArrayList", arrayListWrite);
            chart1.Series["Read"].Points.AddXY("ArrayList", arrayListRead);

            chart1.Series["Write"].Points.AddXY("List", listWrite);
            chart1.Series["Read"].Points.AddXY("List", listRead);
        }
    }
}

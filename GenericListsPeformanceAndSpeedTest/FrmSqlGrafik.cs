using System.Windows.Forms;

namespace GenericListsPeformanceAndSpeedTest
{
    public partial class FrmSqlGrafik : Form
    {
        public FrmSqlGrafik(double multiValues, double singleValues, double delete, double truncate)
        {
            InitializeComponent();
            chart1.Series["Add"].Points.AddXY("MultiValues", multiValues);
            chart1.Series["Add"].Points.AddXY("SingleValues", singleValues);

            chart1.Series["Remove"].Points.AddXY("Delete", delete);
            chart1.Series["Remove"].Points.AddXY("Truncate", truncate);
        }
    }
}

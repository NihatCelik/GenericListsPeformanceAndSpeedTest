using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace GenericListsPeformanceAndSpeedTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            listView1.Columns.Clear();

            listView1.Columns.Add("List Type", 150);
            listView1.Columns.Add("Number Of Elements", 250);
            listView1.Columns.Add("Test Time", 150);
            listView1.Columns.Add("Memory Usage", 200);
            int elemanSayisi = Convert.ToInt32(nudElemanSayisi.Value);
            /* 
             * 1) Array
             * 2) ArrayList
             * 3) List 
             */
            Random rnd = new Random();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            #region Array 
            Process processArray = Process.Start("Array.exe", elemanSayisi.ToString());
            string listBytes = "";
            while (!processArray.HasExited)
            {
                processArray.Refresh();
                listBytes = getAvailableRAM(processArray.PrivateMemorySize64);
            }
            watch.Stop();
            TimeSpan ts = watch.Elapsed;

            string[] items = new string[4] { "Array", elemanSayisi.ToString(), ts.TotalMilliseconds + " ms", listBytes.ToString() };
            ListViewItem listViewItem = new ListViewItem(items);
            listView1.Items.Add(listViewItem);
            #endregion 

            watch.Reset();

            watch.Start();
            #region ArrayList 
            Process processArrayList = Process.Start("ArrayList.exe", elemanSayisi.ToString());
            listBytes = "";
            while (!processArrayList.HasExited)
            {
                processArrayList.Refresh();
                listBytes = getAvailableRAM(processArrayList.PrivateMemorySize64);
            }
            watch.Stop();
            ts = watch.Elapsed;

            items = new string[4] { "ArrayList", elemanSayisi.ToString(), ts.TotalMilliseconds + " ms", listBytes.ToString() };
            listViewItem = new ListViewItem(items);
            listView1.Items.Add(listViewItem);
            #endregion 

            watch.Reset();
            watch.Start();

            #region List
            Process processList = Process.Start("List.exe", elemanSayisi.ToString());
            listBytes = "";
            while (!processList.HasExited)
            {
                processList.Refresh();
                listBytes = getAvailableRAM(processList.PrivateMemorySize64);
            }

            watch.Stop();
            ts = watch.Elapsed;

            items = new string[4] { "List", elemanSayisi.ToString(), ts.TotalMilliseconds + " ms", listBytes.ToString() };
            listViewItem = new ListViewItem(items);
            listView1.Items.Add(listViewItem);
            #endregion

            watch.Reset();
            Application.DoEvents();
            string strArrayMB = listView1.Items[0].SubItems[3].Text;
            strArrayMB = strArrayMB.Substring(0, strArrayMB.IndexOf(' '));
            double arrayMB = Convert.ToDouble(strArrayMB);

            string strArrayListMB = listView1.Items[1].SubItems[3].Text;
            strArrayListMB = strArrayListMB.Substring(0, strArrayListMB.IndexOf(' '));
            double arrayListMB = Convert.ToDouble(strArrayListMB);

            string strListMB = listView1.Items[2].SubItems[3].Text;
            strListMB = strListMB.Substring(0, strListMB.IndexOf(' '));
            double listMB = Convert.ToDouble(strListMB);

            FrmHafizaGrafik frm = new FrmHafizaGrafik(arrayMB, arrayListMB, listMB);
            frm.ShowDialog();
        }

        public string getAvailableRAM(long totalBytesOfMemoryUsed)
        {
            double mb = totalBytesOfMemoryUsed / 1024d / 1024d;
            return Math.Round(mb, 1) + " MB";
        }

        private void btnSQLTestEt_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            listView1.Columns.Clear();

            listView1.Columns.Add("Sorgu Tipi", 150);
            listView1.Columns.Add("Test Edilen Veri Miktarı", 250);
            listView1.Columns.Add("Test Süresi", 150);
            int elemanSayisi = Convert.ToInt32(nudElemanSayisi.Value);
            if (elemanSayisi > 1000)
            {
                MessageBox.Show("Eleman Sayısı 1000'den Fazla Olamaz!");
                return;
            }
            Application.DoEvents();
            string connStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=DbYapayZeka;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            string query = "Insert Into tblDeneme(Veri) Values('0'),";
            for (int i = 1; i < elemanSayisi; i++)
            {
                query += "('" + i.ToString() + "'),";
            }
            query = query.Remove(query.Length - 1);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            TimeSpan ts = sw.Elapsed;
            var items = new string[3] { "MultiValues", elemanSayisi.ToString(), ts.TotalMilliseconds + " ms" };
            ListViewItem listViewItem = new ListViewItem(items);
            listView1.Items.Add(listViewItem);

            sw.Reset();

            sw.Start();
            query = "Delete From tblDeneme";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            ts = sw.Elapsed;
            items = new string[3] { "Delete", elemanSayisi.ToString(), ts.TotalMilliseconds + " ms" };
            listViewItem = new ListViewItem(items);
            listView1.Items.Add(listViewItem);

            sw.Reset();

            sw.Start();

            for (int i = 1; i < elemanSayisi; i++)
            {
                query = "Insert Into tblDeneme(Veri) Values('" + i.ToString() + "')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }

            ts = sw.Elapsed;
            items = new string[3] { "SingleValues", elemanSayisi.ToString(), ts.TotalMilliseconds + " ms" };
            listViewItem = new ListViewItem(items);
            listView1.Items.Add(listViewItem);

            sw.Reset();

            sw.Start();
            query = "Truncate Table tblDeneme";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            ts = sw.Elapsed;
            items = new string[3] { "Truncate", elemanSayisi.ToString(), ts.TotalMilliseconds + " ms" };
            listViewItem = new ListViewItem(items);
            listView1.Items.Add(listViewItem);

            sw.Stop();
        }

        private void btnSQLGrafik_Click(object sender, EventArgs e)
        {
            string strMultiValues = listView1.Items[0].SubItems[2].Text;
            strMultiValues = strMultiValues.Substring(0, strMultiValues.IndexOf(' '));
            double multiValues = Convert.ToDouble(strMultiValues);

            string strDelete = listView1.Items[1].SubItems[2].Text;
            strDelete = strDelete.Substring(0, strDelete.IndexOf(' '));
            double delete = Convert.ToDouble(strDelete);

            string strSingleValues = listView1.Items[2].SubItems[2].Text;
            strSingleValues = strSingleValues.Substring(0, strSingleValues.IndexOf(' '));
            double singleValues = Convert.ToDouble(strSingleValues);

            string strTruncate = listView1.Items[3].SubItems[2].Text;
            strTruncate = strTruncate.Substring(0, strTruncate.IndexOf(' '));
            double truncate = Convert.ToDouble(strTruncate);

            FrmSqlGrafik frm = new FrmSqlGrafik(multiValues, singleValues, delete, truncate);
            frm.ShowDialog();
        }

        TimeSpan arrayWriteTime, arrayReadTime, arrayListWriteTime, arrayListReadTime, listWriteTime, listReadTime;

        private void btnArraySpeedTest_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.Columns.Add("List Type", 150);
            listView1.Columns.Add("Number Of Elements", 250);
            listView1.Columns.Add("Test Time", 150);

            int elemanSayisi = Convert.ToInt32(nudElemanSayisi.Value);
            /* 
             * 1) Array
             * 2) ArrayList
             * 3) List 
             */
            System.Random rnd = new System.Random();
            TimeSpan ts;
            Stopwatch watch = new Stopwatch();
            ListViewItem listViewItem;
            string[] items;
            int sum = 0;
            watch.Start();
            #region Array 
            int[] array = new int[elemanSayisi];
            for (int i = 0; i < elemanSayisi; i++)
            {
                array[i] = rnd.Next(elemanSayisi);
            }
            watch.Stop();
            arrayWriteTime = ts = watch.Elapsed;
            ListeyeEkle("Array Write", elemanSayisi, ts, out items, out listViewItem);

            watch.Reset();
            watch.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
                sum += array[i];
            }
            watch.Stop();
            arrayReadTime = ts = watch.Elapsed;
            ListeyeEkle("Array Read", elemanSayisi, ts, out items, out listViewItem);

            #endregion 

            watch.Reset();
            watch.Start();

            #region ArrayList  
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < elemanSayisi; i++)
            {
                arrayList.Add(rnd.Next(elemanSayisi));
            }
            watch.Stop();
            arrayListWriteTime = ts = watch.Elapsed;

            ListeyeEkle("ArrayList Write", elemanSayisi, ts, out items, out listViewItem);

            watch.Reset();
            watch.Start();
            sum = 0;
            for (int i = 0; i < elemanSayisi; i++)
            {
                sum += Convert.ToInt32(arrayList[i]);
            }
            watch.Stop();
            arrayListReadTime = ts = watch.Elapsed;
            ListeyeEkle("ArrayList Read", elemanSayisi, ts, out items, out listViewItem);
            #endregion 

            watch.Reset();
            watch.Start();

            #region List
            List<int> list = new List<int>();
            for (int i = 0; i < elemanSayisi; i++)
            {
                list.Add(rnd.Next(elemanSayisi));
            }
            watch.Stop();
            listWriteTime = ts = watch.Elapsed;

            ListeyeEkle("List Write", elemanSayisi, ts, out items, out listViewItem);
            watch.Reset();
            watch.Start();

            sum = 0;
            for (int i = 0; i < elemanSayisi; i++)
            {
                sum += list[i];
            }

            watch.Stop();
            listReadTime = ts = watch.Elapsed;

            ListeyeEkle("List Read", elemanSayisi, ts, out items, out listViewItem);
            watch.Reset();
            #endregion

            new FrmGrafik(arrayWriteTime.TotalMilliseconds, arrayReadTime.TotalMilliseconds,
             arrayListWriteTime.TotalMilliseconds, arrayListReadTime.TotalMilliseconds,
             listWriteTime.TotalMilliseconds, listReadTime.TotalMilliseconds).Show();
        }

        private void ListeyeEkle(string diziAdi, int elemanSayisi, TimeSpan ts, out string[] items, out ListViewItem listViewItem)
        {
            items = new string[3] { diziAdi, elemanSayisi.ToString(), ts.TotalMilliseconds + " ms" };
            listViewItem = new ListViewItem(items);
            listView1.Items.Add(listViewItem);
        }
    }
}
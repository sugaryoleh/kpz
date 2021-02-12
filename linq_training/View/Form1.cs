using geolocmanager;
using LoadManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        DataSelector dataSelector;
        CSVLoadDataReader csvldr;
        List<LoadData> loadDatas;
        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
            dataSelector = new DataSelector();
            csvldr = new CSVLoadDataReader();
            //loadDatas = csvldr.Read(@"C:\Users\sugar\source\repos\linq_training\loads tracking 15-16_12 - short.csv");
            loadDatas = csvldr.Read(@"C:\Users\sugar\source\repos\linq_training\loads tracking 15-16_12.csv");
        }

        private void dataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramsBox.Items.Clear();
            if (dataType.SelectedIndex == 0)
            {
                var disps = dataSelector.GetDispatchers(loadDatas);
                foreach (string name in disps)
                {
                    paramsBox.Items.Add(name);
                }
            }
            else if (dataType.SelectedIndex == 1)
            {
                var datas = dataSelector.GetShipperCities(loadDatas);
                foreach (string data in datas)
                {
                    paramsBox.Items.Add(data);
                }
            }
            else if (dataType.SelectedIndex == 2)
            {
                var datas = dataSelector.GetReceiverCities(loadDatas);
                foreach (string data in datas)
                {
                    paramsBox.Items.Add(data);
                }
            }
            else if (dataType.SelectedIndex == 3 || dataType.SelectedIndex == 4)
            {
                var datas = dataSelector.GetTillDates(loadDatas);
                foreach (DateNTime data in datas)
                {
                    paramsBox.Items.Add(data.ToString());
                }
            }
            else if (dataType.SelectedIndex == 5)
            {
                var datas = dataSelector.GetStatuses();
                foreach (Status data in datas)
                {
                    paramsBox.Items.Add(data.ToString());
                }
            }
            else if (dataType.SelectedIndex == 6 || dataType.SelectedIndex == 7)
            {
                var datas = dataSelector.GetTimezones();
                foreach (geolocmanager.TimeZone data in datas)
                {
                    paramsBox.Items.Add(data.ToString());
                }
            }
        }
        private void formTable()
        {
            dataTable.ColumnCount = 0;
            if (Dispatcher.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Dispatch";
            }
            if (Order.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Order";
            }
            if (shc.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Shipper City";
            }
            if (shs.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Shipper State";
            }
            if (rs.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Receiver City";
            }
            if (rs.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Receiver State";
            }
            if (ae.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Arrive early";
            }
            if (al.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Arrive late";
            }
            if (truck.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Truck";
            }
            if (status.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Status";
            }
            if (mi.Checked)
            {
                dataTable.ColumnCount += 1;
                dataTable.Columns[dataTable.ColumnCount - 1].Name = "Miles";
            }
        }
        private void SetupDataGridView()
        {

            dataTable.ColumnCount = 0;

            
            dataTable.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataTable.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataTable.GridColor = Color.Black;
            dataTable.RowHeadersVisible = false;

            
           

            //dataTable.SelectionMode =
            //    DataGridViewSelectionMode.FullRowSelect;
            //dataTable.MultiSelect = false;
            // dataTable.Dock = DockStyle.Fill;

            //dataTable.CellFormatting += new
            //    DataGridViewCellFormattingEventHandler(
            //    dataTable_CellFormatting);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formTable();
            if(dataType.SelectedIndex == 0)
            {
                var datas = dataSelector.GetLoadsOfDispatch(paramsBox.Text, loadDatas);
                foreach (LoadData data in datas)
                {
                    string[] parameters = { data.dispatch, data.order, data.fromCity, data.fromState,
                    data.toCity, data.toState, data.arriveEarly.ToString(), data.arriveLate.ToString(), data.truck, data.status.ToString(), data.milesToDelivery.ToString()};
                    dataTable.Rows.Add(filter(parameters));

                }
            }
            if (dataType.SelectedIndex == 1)
            {
                var datas = dataSelector.GetLoadsFrom(paramsBox.Text, loadDatas);
                foreach (LoadData data in datas)
                {
                    string[] parameters = { data.dispatch, data.order, data.fromCity, data.fromState,
                    data.toCity, data.toState, data.arriveEarly.ToString(), data.arriveLate.ToString(), data.truck, data.status.ToString(), data.milesToDelivery.ToString()};
                    dataTable.Rows.Add(filter(parameters));

                }
            }
            if (dataType.SelectedIndex == 2)
            {
                var datas = dataSelector.GetLoadsTo(paramsBox.Text, loadDatas);
                foreach (LoadData data in datas)
                {
                    string[] parameters = { data.dispatch, data.order, data.fromCity, data.fromState,
                    data.toCity, data.toState, data.arriveEarly.ToString(), data.arriveLate.ToString(), data.truck, data.status.ToString(), data.milesToDelivery.ToString()};
                    dataTable.Rows.Add(parameters);
                    dataTable.Rows.Add(filter(parameters));

                }
            }
            if (dataType.SelectedIndex == 3)
            {
                DateNTime dnt = DateNTime.Serializer.Serialize(paramsBox.Text);
                var datas = dataSelector.GetLoadsTillDateNTime(dnt, loadDatas);
                foreach (LoadData data in datas)
                {
                    string[] parameters = { data.dispatch, data.order, data.fromCity, data.fromState,
                    data.toCity, data.toState, data.arriveEarly.ToString(), data.arriveLate.ToString(), data.truck, data.status.ToString(), data.milesToDelivery.ToString()};
                    dataTable.Rows.Add(filter(parameters));

                }
            }
            if (dataType.SelectedIndex == 4)
            {
                DateNTime dnt = DateNTime.Serializer.Serialize(paramsBox.Text);
                var datas = dataSelector.GetLoadsFromDateNTime(dnt, loadDatas);
                foreach (LoadData data in datas)
                {
                    string[] parameters = { data.dispatch, data.order, data.fromCity, data.fromState,
                    data.toCity, data.toState, data.arriveEarly.ToString(), data.arriveLate.ToString(), data.truck, data.status.ToString(), data.milesToDelivery.ToString()};
                    dataTable.Rows.Add(filter(parameters));

                }
            }
            if (dataType.SelectedIndex == 5)
            {
                var datas = dataSelector.GetLoadsOfSpecificStatus(StatusMethods.Serializer.Serialize(paramsBox.Text), loadDatas);
                foreach (LoadData data in datas)
                {
                    string[] parameters = { data.dispatch, data.order, data.fromCity, data.fromState,
                    data.toCity, data.toState, data.arriveEarly.ToString(), data.arriveLate.ToString(), data.truck, data.status.ToString(), data.milesToDelivery.ToString()};
                    dataTable.Rows.Add(filter(parameters));

                }
            }
            if (dataType.SelectedIndex == 6)
            {
                var datas = dataSelector.GetLoadsFromTimeZone(TimeZoneMethods.Serializer.Serialize(paramsBox.Text), loadDatas);
                foreach (LoadData data in datas)
                {
                    string[] parameters = { data.dispatch, data.order, data.fromCity, data.fromState,
                    data.toCity, data.toState, data.arriveEarly.ToString(), data.arriveLate.ToString(), data.truck, data.status.ToString(), data.milesToDelivery.ToString()};
                    dataTable.Rows.Add(filter(parameters));

                }
            }
            if (dataType.SelectedIndex == 7)
            {
                var datas = dataSelector.GetLoadsToTimeZone(TimeZoneMethods.Serializer.Serialize(paramsBox.Text), loadDatas);
                foreach (LoadData data in datas)
                {
                    string[] parameters = { data.dispatch, data.order, data.fromCity, data.fromState,
                    data.toCity, data.toState, data.arriveEarly.ToString(), data.arriveLate.ToString(), data.truck, 
                        data.status.ToString(), data.milesToDelivery.ToString()};
                    dataTable.Rows.Add(filter(parameters));

                }
            }
        }
        private string[] filter(string [] incoming)
        {
            List<string> newParams = new List<string>();
           
            if(Dispatcher.Checked)
            {
                newParams.Add(incoming[0]);
            }
            if(Order.Checked)
            {
                newParams.Add(incoming[1]);
            }
            if (shc.Checked)
            {
                newParams.Add(incoming[2]);
            }
            if (shs.Checked)
            {
                newParams.Add(incoming[3]);
            }
            if (rc.Checked)
            {
                newParams.Add(incoming[4]);
            }
            if (rs.Checked)
            {
                newParams.Add(incoming[5]);
            }
            if (ae.Checked)
            {
                newParams.Add(incoming[6]);
            }
            if (al.Checked)
            {
                newParams.Add(incoming[7]);
            }
            if (truck.Checked)
            {
                newParams.Add(incoming[8]);
            }
            if (status.Checked)
            {
                newParams.Add(incoming[9]);
            }
            if (mi.Checked)
            {
                newParams.Add(incoming[10]);
            }
            return newParams.ToArray();
        }

        private void Dispatcher_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

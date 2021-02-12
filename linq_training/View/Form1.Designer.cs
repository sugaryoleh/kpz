
namespace View
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Order = new System.Windows.Forms.CheckBox();
            this.shc = new System.Windows.Forms.CheckBox();
            this.shs = new System.Windows.Forms.CheckBox();
            this.rc = new System.Windows.Forms.CheckBox();
            this.rs = new System.Windows.Forms.CheckBox();
            this.ae = new System.Windows.Forms.CheckBox();
            this.dataType = new System.Windows.Forms.ComboBox();
            this.paramsBox = new System.Windows.Forms.ComboBox();
            this.Dispatcher = new System.Windows.Forms.CheckBox();
            this.al = new System.Windows.Forms.CheckBox();
            this.truck = new System.Windows.Forms.CheckBox();
            this.status = new System.Windows.Forms.CheckBox();
            this.mi = new System.Windows.Forms.CheckBox();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(170, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(670, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Checked = true;
            this.Order.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Order.Location = new System.Drawing.Point(2, 88);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(67, 21);
            this.Order.TabIndex = 3;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // shc
            // 
            this.shc.AutoSize = true;
            this.shc.Checked = true;
            this.shc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shc.Location = new System.Drawing.Point(2, 115);
            this.shc.Name = "shc";
            this.shc.Size = new System.Drawing.Size(104, 21);
            this.shc.TabIndex = 4;
            this.shc.Text = "Shipper city";
            this.shc.UseVisualStyleBackColor = true;
            // 
            // shs
            // 
            this.shs.AutoSize = true;
            this.shs.Checked = true;
            this.shs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shs.Location = new System.Drawing.Point(2, 142);
            this.shs.Name = "shs";
            this.shs.Size = new System.Drawing.Size(114, 21);
            this.shs.TabIndex = 5;
            this.shs.Text = "Shipper state";
            this.shs.UseVisualStyleBackColor = true;
            // 
            // rc
            // 
            this.rc.AutoSize = true;
            this.rc.Checked = true;
            this.rc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rc.Location = new System.Drawing.Point(2, 169);
            this.rc.Name = "rc";
            this.rc.Size = new System.Drawing.Size(111, 21);
            this.rc.TabIndex = 6;
            this.rc.Text = "Receiver city";
            this.rc.UseVisualStyleBackColor = true;
            // 
            // rs
            // 
            this.rs.AutoSize = true;
            this.rs.Checked = true;
            this.rs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rs.Location = new System.Drawing.Point(2, 196);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(121, 21);
            this.rs.TabIndex = 7;
            this.rs.Text = "Receiver state";
            this.rs.UseVisualStyleBackColor = true;
            // 
            // ae
            // 
            this.ae.AutoSize = true;
            this.ae.Checked = true;
            this.ae.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ae.Location = new System.Drawing.Point(2, 223);
            this.ae.Name = "ae";
            this.ae.Size = new System.Drawing.Size(102, 21);
            this.ae.TabIndex = 8;
            this.ae.Text = "Arrive early";
            this.ae.UseVisualStyleBackColor = true;
            this.ae.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // dataType
            // 
            this.dataType.FormattingEnabled = true;
            this.dataType.Items.AddRange(new object[] {
            "Dispatch",
            "Shipper address",
            "Delivery address",
            "Till date and time",
            "From date and time",
            "Status",
            "Time zone from",
            "Time zone to"});
            this.dataType.Location = new System.Drawing.Point(2, 1);
            this.dataType.Name = "dataType";
            this.dataType.Size = new System.Drawing.Size(162, 24);
            this.dataType.TabIndex = 9;
            this.dataType.SelectedIndexChanged += new System.EventHandler(this.dataType_SelectedIndexChanged);
            // 
            // paramsBox
            // 
            this.paramsBox.FormattingEnabled = true;
            this.paramsBox.Location = new System.Drawing.Point(2, 31);
            this.paramsBox.Name = "paramsBox";
            this.paramsBox.Size = new System.Drawing.Size(162, 24);
            this.paramsBox.TabIndex = 10;
            // 
            // Dispatcher
            // 
            this.Dispatcher.AutoSize = true;
            this.Dispatcher.Checked = true;
            this.Dispatcher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Dispatcher.Location = new System.Drawing.Point(2, 61);
            this.Dispatcher.Name = "Dispatcher";
            this.Dispatcher.Size = new System.Drawing.Size(98, 21);
            this.Dispatcher.TabIndex = 11;
            this.Dispatcher.Text = "Dispatcher";
            this.Dispatcher.UseVisualStyleBackColor = true;
            this.Dispatcher.CheckedChanged += new System.EventHandler(this.Dispatcher_CheckedChanged);
            // 
            // al
            // 
            this.al.AutoSize = true;
            this.al.Checked = true;
            this.al.CheckState = System.Windows.Forms.CheckState.Checked;
            this.al.Location = new System.Drawing.Point(2, 251);
            this.al.Name = "al";
            this.al.Size = new System.Drawing.Size(94, 21);
            this.al.TabIndex = 12;
            this.al.Text = "Arrive late";
            this.al.UseVisualStyleBackColor = true;
            // 
            // truck
            // 
            this.truck.AutoSize = true;
            this.truck.Checked = true;
            this.truck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.truck.Location = new System.Drawing.Point(2, 279);
            this.truck.Name = "truck";
            this.truck.Size = new System.Drawing.Size(66, 21);
            this.truck.TabIndex = 13;
            this.truck.Text = "Truck";
            this.truck.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Checked = true;
            this.status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status.Location = new System.Drawing.Point(2, 307);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(70, 21);
            this.status.TabIndex = 14;
            this.status.Text = "Status";
            this.status.UseVisualStyleBackColor = true;
            // 
            // mi
            // 
            this.mi.AutoSize = true;
            this.mi.Checked = true;
            this.mi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi.Location = new System.Drawing.Point(2, 335);
            this.mi.Name = "mi";
            this.mi.Size = new System.Drawing.Size(131, 21);
            this.mi.TabIndex = 15;
            this.mi.Text = "Miles to delivery";
            this.mi.UseVisualStyleBackColor = true;
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Location = new System.Drawing.Point(170, 1);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(670, 417);
            this.dataTable.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Track";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.mi);
            this.Controls.Add(this.status);
            this.Controls.Add(this.truck);
            this.Controls.Add(this.al);
            this.Controls.Add(this.Dispatcher);
            this.Controls.Add(this.paramsBox);
            this.Controls.Add(this.dataType);
            this.Controls.Add(this.ae);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.rc);
            this.Controls.Add(this.shs);
            this.Controls.Add(this.shc);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Load tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox Order;
        private System.Windows.Forms.CheckBox shc;
        private System.Windows.Forms.CheckBox shs;
        private System.Windows.Forms.CheckBox rc;
        private System.Windows.Forms.CheckBox rs;
        private System.Windows.Forms.CheckBox ae;
        private System.Windows.Forms.ComboBox dataType;
        private System.Windows.Forms.ComboBox paramsBox;
        private System.Windows.Forms.CheckBox Dispatcher;
        private System.Windows.Forms.CheckBox al;
        private System.Windows.Forms.CheckBox truck;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.CheckBox mi;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button button1;
    }
}


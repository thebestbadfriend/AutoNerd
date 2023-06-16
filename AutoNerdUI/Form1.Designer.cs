namespace AutoNerdUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcMain = new TabControl();
            tcMain_Page1 = new TabPage();
            lboPCInfo = new ListBox();
            tcMain_Page2 = new TabPage();
            btnRefreshPCInfo = new Button();
            tcMain.SuspendLayout();
            tcMain_Page1.SuspendLayout();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tcMain_Page1);
            tcMain.Controls.Add(tcMain_Page2);
            tcMain.Location = new Point(2, 2);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(772, 659);
            tcMain.TabIndex = 0;
            // 
            // tcMain_Page1
            // 
            tcMain_Page1.BackColor = Color.DimGray;
            tcMain_Page1.Controls.Add(btnRefreshPCInfo);
            tcMain_Page1.Controls.Add(lboPCInfo);
            tcMain_Page1.Location = new Point(4, 24);
            tcMain_Page1.Name = "tcMain_Page1";
            tcMain_Page1.Padding = new Padding(3);
            tcMain_Page1.Size = new Size(764, 631);
            tcMain_Page1.TabIndex = 0;
            tcMain_Page1.Text = "Tell Me About My PC";
            // 
            // lboPCInfo
            // 
            lboPCInfo.FormattingEnabled = true;
            lboPCInfo.ItemHeight = 15;
            lboPCInfo.Location = new Point(6, 9);
            lboPCInfo.Name = "lboPCInfo";
            lboPCInfo.Size = new Size(615, 619);
            lboPCInfo.TabIndex = 0;
            // 
            // tcMain_Page2
            // 
            tcMain_Page2.BackColor = Color.DimGray;
            tcMain_Page2.Location = new Point(4, 24);
            tcMain_Page2.Name = "tcMain_Page2";
            tcMain_Page2.Padding = new Padding(3);
            tcMain_Page2.Size = new Size(764, 631);
            tcMain_Page2.TabIndex = 1;
            tcMain_Page2.Text = "Help Me Fix My PC";
            // 
            // btnRefreshPCInfo
            // 
            btnRefreshPCInfo.Location = new Point(627, 9);
            btnRefreshPCInfo.Name = "btnRefreshPCInfo";
            btnRefreshPCInfo.Size = new Size(131, 49);
            btnRefreshPCInfo.TabIndex = 1;
            btnRefreshPCInfo.Text = "Refresh";
            btnRefreshPCInfo.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 673);
            Controls.Add(tcMain);
            Name = "Main";
            Text = "Auto Nerd";
            tcMain.ResumeLayout(false);
            tcMain_Page1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMain;
        private TabPage tcMain_Page1;
        private TabPage tcMain_Page2;
        private ListBox lboPCInfo;
        private Button btnRefreshPCInfo;
    }
}
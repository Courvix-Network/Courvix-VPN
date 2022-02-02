
namespace Courvix_VPN
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerlbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.headerbar = new Guna.UI2.WinForms.Guna2Separator();
            this.statuslbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.serversCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.xbtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.leftborder = new Guna.UI2.WinForms.Guna2Panel();
            this.rightborder = new Guna.UI2.WinForms.Guna2Panel();
            this.topborder = new Guna.UI2.WinForms.Guna2Panel();
            this.bottomborder = new Guna.UI2.WinForms.Guna2Panel();
            this.ConnectBTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.RPCCheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.connectingIndicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.lblVersion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // headerlbl
            // 
            this.headerlbl.BackColor = System.Drawing.Color.Transparent;
            this.headerlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerlbl.IsSelectionEnabled = false;
            this.headerlbl.Location = new System.Drawing.Point(121, 17);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(123, 32);
            this.headerlbl.TabIndex = 0;
            this.headerlbl.Text = "Courvix VPN";
            // 
            // headerbar
            // 
            this.headerbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.headerbar.FillThickness = 2;
            this.headerbar.Location = new System.Drawing.Point(12, 61);
            this.headerbar.Name = "headerbar";
            this.headerbar.Size = new System.Drawing.Size(340, 11);
            this.headerbar.TabIndex = 1;
            // 
            // statuslbl
            // 
            this.statuslbl.BackColor = System.Drawing.Color.Transparent;
            this.statuslbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.ForeColor = System.Drawing.Color.White;
            this.statuslbl.IsSelectionEnabled = false;
            this.statuslbl.Location = new System.Drawing.Point(3, 415);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(38, 17);
            this.statuslbl.TabIndex = 2;
            this.statuslbl.Text = "Status:";
            // 
            // serversCB
            // 
            this.serversCB.Animated = true;
            this.serversCB.BackColor = System.Drawing.Color.Transparent;
            this.serversCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.serversCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.serversCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serversCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.serversCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(50)))));
            this.serversCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(50)))));
            this.serversCB.FocusedState.Parent = this.serversCB;
            this.serversCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.serversCB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serversCB.HoverState.Parent = this.serversCB;
            this.serversCB.ItemHeight = 30;
            this.serversCB.Items.AddRange(new object[] { "CONNECTION-1", "CONNECTION-2", "CONNECTION-3", "CONNECTION-4", "CONNECTION-5" });
            this.serversCB.ItemsAppearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serversCB.ItemsAppearance.Parent = this.serversCB;
            this.serversCB.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.serversCB.Location = new System.Drawing.Point(12, 135);
            this.serversCB.Name = "serversCB";
            this.serversCB.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.serversCB.ShadowDecoration.Enabled = true;
            this.serversCB.ShadowDecoration.Parent = this.serversCB;
            this.serversCB.Size = new System.Drawing.Size(340, 36);
            this.serversCB.TabIndex = 3;
            this.serversCB.SelectedIndexChanged += new System.EventHandler(this.serversCB_SelectedIndexChanged);
            // 
            // xbtn
            // 
            this.xbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.xbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.xbtn.HoverState.Parent = this.xbtn;
            this.xbtn.IconColor = System.Drawing.Color.White;
            this.xbtn.Location = new System.Drawing.Point(319, 1);
            this.xbtn.Name = "xbtn";
            this.xbtn.ShadowDecoration.Parent = this.xbtn;
            this.xbtn.Size = new System.Drawing.Size(45, 29);
            this.xbtn.TabIndex = 4;
            this.xbtn.Click += new System.EventHandler(this.xbtn_Click);
            // 
            // leftborder
            // 
            this.leftborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.leftborder.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftborder.Location = new System.Drawing.Point(0, 0);
            this.leftborder.Name = "leftborder";
            this.leftborder.ShadowDecoration.Parent = this.leftborder;
            this.leftborder.Size = new System.Drawing.Size(3, 435);
            this.leftborder.TabIndex = 5;
            // 
            // rightborder
            // 
            this.rightborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.rightborder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightborder.Location = new System.Drawing.Point(361, 0);
            this.rightborder.Name = "rightborder";
            this.rightborder.ShadowDecoration.Parent = this.rightborder;
            this.rightborder.Size = new System.Drawing.Size(3, 435);
            this.rightborder.TabIndex = 6;
            // 
            // topborder
            // 
            this.topborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.topborder.Dock = System.Windows.Forms.DockStyle.Top;
            this.topborder.Location = new System.Drawing.Point(3, 0);
            this.topborder.Name = "topborder";
            this.topborder.ShadowDecoration.Parent = this.topborder;
            this.topborder.Size = new System.Drawing.Size(358, 3);
            this.topborder.TabIndex = 7;
            // 
            // bottomborder
            // 
            this.bottomborder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.bottomborder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomborder.Location = new System.Drawing.Point(3, 432);
            this.bottomborder.Name = "bottomborder";
            this.bottomborder.ShadowDecoration.Parent = this.bottomborder;
            this.bottomborder.Size = new System.Drawing.Size(358, 3);
            this.bottomborder.TabIndex = 8;
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Animated = true;
            this.ConnectBTN.BackColor = System.Drawing.Color.Transparent;
            this.ConnectBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.ConnectBTN.BorderRadius = 3;
            this.ConnectBTN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.ConnectBTN.CheckedState.Parent = this.ConnectBTN;
            this.ConnectBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBTN.CustomImages.Parent = this.ConnectBTN;
            this.ConnectBTN.DisabledState.Parent = this.ConnectBTN;
            this.ConnectBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.ConnectBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBTN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ConnectBTN.HoverState.Parent = this.ConnectBTN;
            this.ConnectBTN.Location = new System.Drawing.Point(48, 270);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.ConnectBTN.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.ConnectBTN.ShadowDecoration.Enabled = true;
            this.ConnectBTN.ShadowDecoration.Parent = this.ConnectBTN;
            this.ConnectBTN.Size = new System.Drawing.Size(267, 45);
            this.ConnectBTN.TabIndex = 9;
            this.ConnectBTN.Text = "Connect";
            this.ConnectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.headerlbl;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 100;
            this.guna2BorderlessForm1.BorderRadius = 2;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // RPCCheckbox
            // 
            this.RPCCheckbox.Animated = true;
            this.RPCCheckbox.AutoSize = true;
            this.RPCCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.RPCCheckbox.CheckedState.BorderRadius = 2;
            this.RPCCheckbox.CheckedState.BorderThickness = 1;
            this.RPCCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.RPCCheckbox.CheckMarkColor = System.Drawing.Color.WhiteSmoke;
            this.RPCCheckbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPCCheckbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RPCCheckbox.Location = new System.Drawing.Point(203, 413);
            this.RPCCheckbox.Name = "RPCCheckbox";
            this.RPCCheckbox.Size = new System.Drawing.Size(152, 19);
            this.RPCCheckbox.TabIndex = 10;
            this.RPCCheckbox.Text = "Show Status On Discord";
            this.RPCCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RPCCheckbox.UncheckedState.BorderRadius = 2;
            this.RPCCheckbox.UncheckedState.BorderThickness = 1;
            this.RPCCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.RPCCheckbox.CheckedChanged += new System.EventHandler(this.RPCCheckbox_CheckedChanged);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(270, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(45, 29);
            this.btnMinimize.TabIndex = 11;
            // 
            // connectingIndicator
            // 
            this.connectingIndicator.CircleSize = 1F;
            this.connectingIndicator.Location = new System.Drawing.Point(107, 416);
            this.connectingIndicator.Name = "connectingIndicator";
            this.connectingIndicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(204)))));
            this.connectingIndicator.ShadowDecoration.Parent = this.connectingIndicator;
            this.connectingIndicator.Size = new System.Drawing.Size(17, 13);
            this.connectingIndicator.TabIndex = 12;
            this.connectingIndicator.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(3, 4);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 15);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "version n/a";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(364, 435);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.connectingIndicator);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.RPCCheckbox);
            this.Controls.Add(this.ConnectBTN);
            this.Controls.Add(this.bottomborder);
            this.Controls.Add(this.topborder);
            this.Controls.Add(this.rightborder);
            this.Controls.Add(this.leftborder);
            this.Controls.Add(this.xbtn);
            this.Controls.Add(this.serversCB);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.headerbar);
            this.Controls.Add(this.headerlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Courvix VPN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel headerlbl;
        private Guna.UI2.WinForms.Guna2Separator headerbar;
        private Guna.UI2.WinForms.Guna2HtmlLabel statuslbl;
        private Guna.UI2.WinForms.Guna2ComboBox serversCB;
        private Guna.UI2.WinForms.Guna2ControlBox xbtn;
        private Guna.UI2.WinForms.Guna2Panel leftborder;
        private Guna.UI2.WinForms.Guna2Panel rightborder;
        private Guna.UI2.WinForms.Guna2Panel topborder;
        private Guna.UI2.WinForms.Guna2Panel bottomborder;
        private Guna.UI2.WinForms.Guna2Button ConnectBTN;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CheckBox RPCCheckbox;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ProgressIndicator connectingIndicator;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVersion;
    }
}


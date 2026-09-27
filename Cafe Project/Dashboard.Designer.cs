namespace Cafe_Project
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            btnLogOut = new LinkLabel();
            btnExit = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            btnRemove = new Guna.UI2.WinForms.Guna2Button();
            btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            uC_RemoveItem1 = new Cafe_Project.AllUserControls.UC_RemoveItem();
            uC_UpdateItems1 = new Cafe_Project.AllUserControls.UC_UpdateItems();
            uC_PlaceOrder1 = new Cafe_Project.AllUserControls.UC_PlaceOrder();
            uC_AddItems1 = new Cafe_Project.AllUserControls.UC_AddItems();
            uC_Welcome1 = new Cafe_Project.AllUserControls.UC_Welcome();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 115, 225);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnAddItems);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnPlaceOrder);
            guna2Transition1.SetDecoration(panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 790);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            guna2Transition1.SetDecoration(btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            btnLogOut.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogOut.LinkColor = Color.White;
            btnLogOut.Location = new Point(112, 705);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(88, 32);
            btnLogOut.TabIndex = 5;
            btnLogOut.TabStop = true;
            btnLogOut.Text = "Logout";
            btnLogOut.LinkClicked += btnLogOut_LinkClicked;
            // 
            // btnExit
            // 
            guna2Transition1.SetDecoration(btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(6, 4);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(45, 42);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // btnAddItems
            // 
            btnAddItems.BorderRadius = 19;
            btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnAddItems.CheckedState.FillColor = Color.White;
            btnAddItems.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnAddItems.CustomizableEdges = customizableEdges11;
            guna2Transition1.SetDecoration(btnAddItems, Guna.UI2.AnimatorNS.DecorationType.None);
            btnAddItems.DisabledState.BorderColor = Color.DarkGray;
            btnAddItems.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddItems.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddItems.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddItems.FillColor = Color.FromArgb(0, 118, 225);
            btnAddItems.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddItems.ForeColor = Color.White;
            btnAddItems.Location = new Point(58, 219);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAddItems.Size = new Size(256, 54);
            btnAddItems.TabIndex = 3;
            btnAddItems.Text = "Add Items";
            btnAddItems.Click += btnAddItems_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 19;
            btnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnUpdate.CheckedState.FillColor = Color.White;
            btnUpdate.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnUpdate.CustomizableEdges = customizableEdges13;
            guna2Transition1.SetDecoration(btnUpdate, Guna.UI2.AnimatorNS.DecorationType.None);
            btnUpdate.DisabledState.BorderColor = Color.DarkGray;
            btnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdate.FillColor = Color.FromArgb(0, 118, 225);
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(58, 297);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnUpdate.Size = new Size(256, 54);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Items";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.BorderRadius = 19;
            btnRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnRemove.CheckedState.FillColor = Color.White;
            btnRemove.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnRemove.CustomizableEdges = customizableEdges15;
            guna2Transition1.SetDecoration(btnRemove, Guna.UI2.AnimatorNS.DecorationType.None);
            btnRemove.DisabledState.BorderColor = Color.DarkGray;
            btnRemove.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRemove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRemove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRemove.FillColor = Color.FromArgb(0, 118, 225);
            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(58, 375);
            btnRemove.Name = "btnRemove";
            btnRemove.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnRemove.Size = new Size(256, 54);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove Items";
            btnRemove.Click += btnRemove_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BorderRadius = 19;
            btnPlaceOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnPlaceOrder.CheckedState.FillColor = Color.White;
            btnPlaceOrder.CheckedState.ForeColor = Color.FromArgb(0, 118, 225);
            btnPlaceOrder.CustomizableEdges = customizableEdges17;
            guna2Transition1.SetDecoration(btnPlaceOrder, Guna.UI2.AnimatorNS.DecorationType.None);
            btnPlaceOrder.DisabledState.BorderColor = Color.DarkGray;
            btnPlaceOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPlaceOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPlaceOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPlaceOrder.FillColor = Color.FromArgb(0, 118, 225);
            btnPlaceOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPlaceOrder.ForeColor = Color.White;
            btnPlaceOrder.Location = new Point(58, 138);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnPlaceOrder.Size = new Size(256, 54);
            btnPlaceOrder.TabIndex = 0;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(uC_RemoveItem1);
            panel2.Controls.Add(uC_UpdateItems1);
            panel2.Controls.Add(uC_PlaceOrder1);
            panel2.Controls.Add(uC_AddItems1);
            panel2.Controls.Add(uC_Welcome1);
            guna2Transition1.SetDecoration(panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            panel2.Location = new Point(312, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(1354, 754);
            panel2.TabIndex = 1;
            // 
            // uC_RemoveItem1
            // 
            uC_RemoveItem1.BackColor = Color.White;
            guna2Transition1.SetDecoration(uC_RemoveItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            uC_RemoveItem1.Location = new Point(0, 3);
            uC_RemoveItem1.Name = "uC_RemoveItem1";
            uC_RemoveItem1.Size = new Size(2085, 1136);
            uC_RemoveItem1.TabIndex = 6;
            // 
            // uC_UpdateItems1
            // 
            uC_UpdateItems1.BackColor = Color.White;
            guna2Transition1.SetDecoration(uC_UpdateItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            uC_UpdateItems1.Location = new Point(3, 3);
            uC_UpdateItems1.Name = "uC_UpdateItems1";
            uC_UpdateItems1.Size = new Size(2085, 1136);
            uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            uC_PlaceOrder1.BackColor = Color.White;
            guna2Transition1.SetDecoration(uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            uC_PlaceOrder1.Dock = DockStyle.Fill;
            uC_PlaceOrder1.Location = new Point(0, 0);
            uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            uC_PlaceOrder1.Size = new Size(1354, 754);
            uC_PlaceOrder1.TabIndex = 2;
            uC_PlaceOrder1.Load += uC_PlaceOrder1_Load;
            // 
            // uC_AddItems1
            // 
            uC_AddItems1.BackColor = Color.White;
            guna2Transition1.SetDecoration(uC_AddItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            uC_AddItems1.Dock = DockStyle.Fill;
            uC_AddItems1.Location = new Point(0, 0);
            uC_AddItems1.Name = "uC_AddItems1";
            uC_AddItems1.Size = new Size(1354, 754);
            uC_AddItems1.TabIndex = 1;
            uC_AddItems1.Load += uC_AddItems1_Load;
            // 
            // uC_Welcome1
            // 
            uC_Welcome1.BackColor = Color.White;
            guna2Transition1.SetDecoration(uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            uC_Welcome1.Dock = DockStyle.Fill;
            uC_Welcome1.Location = new Point(0, 0);
            uC_Welcome1.Name = "uC_Welcome1";
            uC_Welcome1.Size = new Size(1354, 754);
            uC_Welcome1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 35;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 35;
            guna2Elipse2.TargetControl = panel2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            guna2Elipse3.TargetControl = panel2;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 30;
            guna2Elipse4.TargetControl = panel2;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 30;
            guna2Elipse5.TargetControl = panel2;
            // 
            // guna2Transition1
            // 
            guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = (PointF)resources.GetObject("animation2.BlindCoeff");
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = (PointF)resources.GetObject("animation2.MosaicCoeff");
            animation2.MosaicShift = (PointF)resources.GetObject("animation2.MosaicShift");
            animation2.MosaicSize = 0;
            animation2.Padding = new Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = (PointF)resources.GetObject("animation2.ScaleCoeff");
            animation2.SlideCoeff = (PointF)resources.GetObject("animation2.SlideCoeff");
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            guna2Transition1.DefaultAnimation = animation2;
            guna2Transition1.MaxAnimationTime = 3000;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 30;
            guna2Elipse6.TargetControl = panel2;
            // 
            // guna2Elipse7
            // 
            guna2Elipse7.BorderRadius = 30;
            guna2Elipse7.TargetControl = panel2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 118, 225);
            ClientSize = new Size(1691, 814);
            Controls.Add(panel2);
            Controls.Add(panel1);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private LinkLabel btnLogOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_AddItems uC_AddItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControls.UC_UpdateItems uC_UpdateItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private AllUserControls.UC_RemoveItem uC_RemoveItem1;
    }
}